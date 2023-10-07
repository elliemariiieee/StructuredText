using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StructuredText.Entities.XML
{
    [XmlRoot(ElementName = "item")]
    public class GroceryItem
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName ="price")]
        public string Price { get; set; }
        [XmlElement(ElementName ="uom")]
        public string Uom { get; set; }
    }
}
