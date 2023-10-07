using Newtonsoft.Json;
using StructuredText.Entities.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredText.Engines
{
    internal class JSONEngine : BaseEngine
    {
        public override void Engine(Files file, string path)
        {
            using (StreamReader reader = new StreamReader(file.Path))
            {
                Student myStudent = JsonConvert.DeserializeObject<Student>(reader.ReadToEnd());
                using (StreamWriter writer = new StreamWriter(path + "\\" + file.FileName + "_out.txt", true))
                {
                    writer.WriteLine($"Line#1 : {myStudent.ToString()}");
                    writer.Close();
                }
            }
        }
    }
}
