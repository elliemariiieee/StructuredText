using StructuredText.Entities.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StructuredText.Engines
{
    internal class XMLEngine : BaseEngine
    {
        public override void Engine(Files file, string path)
        {
            using (var fs = File.Open(file.Path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Grocery));
                var inventory = (Grocery)serializer?.Deserialize(fs);

                using (StreamWriter writer = new StreamWriter(path + "\\" + file.FileName + "_out.txt", true))
                {
                    var linecount = 1;
                    foreach (var item in inventory.Items)
                    {
                        writer.WriteLine($"Line#{linecount++} : Item info => {item.Name} {item.Price}/{item.Uom}");
                    }
                    writer.Close();
                }
            }
        }
    }
}
