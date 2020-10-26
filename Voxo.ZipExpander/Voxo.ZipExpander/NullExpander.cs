using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Voxo.ZipExpander
{
    public class NullExpander : Expander
    {
        public override Stream Expand(Stream stream)
        {
            return stream;
        }
    }
}
