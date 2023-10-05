using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredText
{
    internal class ParsingEngine : IStructuredFile
    {
        StreamReader reader;
        public List<string[]> csvLines = new List<string[]>();
        public List<string[]> pipeLines = new List<string[]>();

        //gets provided list of files and processes them based on file type
        public ParsingEngine(List<String> files)
        {
            foreach(string file in files)
            {
                if (file.Contains(".csv"))
                {
                    getCSVContent(file);
                } else if (file.Contains(".txt"))
                {
                    getPipeContent(file);
                } else
                {
                    //exception help from https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions
                    throw new ArgumentException("Invalid file type", nameof(file));
                }
            }
        }

        //gets file contents of CSV files
        public void getCSVContent(string file)
        {
            reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                csvLines.Add(words);
            }
        }

        //gets file contents of files with pipe separation
        public void getPipeContent(string file)
        {
            reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split('|');
                pipeLines.Add(words);
            }
        }
    }
}
