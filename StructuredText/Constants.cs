using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredText
{
    public static class Constants
    {
        public sealed class Delimiters
        {
            public static string PipeDelimiter = "|";
            public static string CSVDelimiter = ",";
        }

        public sealed class FileExtensions
        {
            public static string Pipe = ".txt";
            public static string CSV = ".csv";
            public static string JSON = ".json";
            public static string XML = ".xml";
        }
    }
}
