using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StructuredText.Entities.JSON
{
    internal class Phone
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("CanContact")]
        public bool CanContact { get; set; }

        public override string ToString()
        {
            return $"Type: {this.Type}, Number: {this.Number}, Can Contact? {this.CanContact.ToString()}";
        }
    }
}
