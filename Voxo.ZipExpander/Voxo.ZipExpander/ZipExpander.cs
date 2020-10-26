using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Voxo.ZipExpander
{
    public class ZipExpander : Expander
    {
        public override Stream Expand(Stream stream)
        {
            MemoryStream mstream = new MemoryStream();
            byte[] buffer = new byte[4096];

            using (ZipFile zf = new ZipFile(stream))
            {
                if (zf.Count != 1 && !zf[0].IsFile)
                {
                    throw new Exception("Zip expander only allowed one zipped file");
                }
                ZipEntry ze = zf[0];

                Stream zipStream = zf.GetInputStream(ze);
                StreamUtils.Copy(zipStream, mstream, buffer);
            }
            
            return mstream;
        }
    }
}
