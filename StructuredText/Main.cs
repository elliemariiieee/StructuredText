using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuredText.Engines;

namespace StructuredText
{
    internal class Main
    {
        static string path = "..\\..\\..\\files";
        List<string> files = new List<string>();
        public List<Files> myFiles = new List<Files>();
        BaseEngine engine;

        public void Start()
        {
            //GetFiles method from https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles?view=net-7.0
            files = Directory.GetFiles(path).ToList();
            createFiles(files);
            Run(myFiles);
        }

        //creates Files for each file in given list
        void createFiles(List<string> files)
        {
            foreach (string file in files)
            {
                string path = file;
                string filename = file.Substring(file.LastIndexOf('\\') + 1);
                filename = filename.Substring(0, filename.LastIndexOf("."));
                string extension;
                if (path.Contains(Constants.FileExtensions.Pipe))
                {
                    extension = Constants.FileExtensions.Pipe;
                }
                else if (path.Contains(Constants.FileExtensions.CSV))
                {
                    extension = Constants.FileExtensions.CSV;
                }
                else if (path.Contains(Constants.FileExtensions.XML))
                {
                    extension = Constants.FileExtensions.XML;
                } else if (path.Contains(Constants.FileExtensions.JSON))
                {
                    extension = Constants.FileExtensions.JSON;
                } else
                {
                    throw new Exception("Invalid file type");
                }
                string delimiter;
                if (extension.Equals(Constants.FileExtensions.Pipe))
                {
                    delimiter = Constants.Delimiters.PipeDelimiter;
                } else if (extension.Equals(Constants.FileExtensions.CSV))
                {
                    delimiter = Constants.Delimiters.CSVDelimiter;
                } else
                {
                    delimiter = null;
                }
                Files tempFile = new Files(path, filename, extension, delimiter);
                myFiles.Add(tempFile);
            }
        }

        //parses each file based on file type
        void Run(List<Files> files)
        {
            foreach(Files file in files)
            {
                switch (file.Extension)
                {
                    case ".csv":
                        engine = new DelimiterEngine();
                        engine.Engine(file, path);
                        break;
                    case ".txt":
                        engine = new DelimiterEngine();
                        engine.Engine(file, path);
                        break;
                    case ".xml":
                        engine = new XMLEngine();
                        engine.Engine(file, path);
                        break;
                    case ".json":
                        engine = new JSONEngine();
                        engine.Engine(file, path);
                        break;
                }
            }
        }
    }
}
