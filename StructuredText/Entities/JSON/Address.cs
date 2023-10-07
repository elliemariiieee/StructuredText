﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StructuredText.Entities.JSON
{
    internal class Address
    {
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{this.StreetAddress}, {this.City}, {this.State} {this.PostalCode}";
        }
    }
}
