using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredText
{
    internal interface IStructuredFile
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string? Delimiter { get; set; }
    }
}
