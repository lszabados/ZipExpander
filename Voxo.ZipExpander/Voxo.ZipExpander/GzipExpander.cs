using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.GZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Voxo.ZipExpander
{
    public class GZipExpander : Expander
    {
        public override Stream Expand(Stream stream)
        {
            byte[] buffer = new byte[4096];
            MemoryStream mstream = new MemoryStream();

            using (GZipInputStream gzipStream = new GZipInputStream(stream))
            {
                StreamUtils.Copy(gzipStream, mstream, buffer);   
            }

            return mstream;
        }
    }
}
