using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StructuredText.Entities.JSON
{
    internal class Student
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("isEnrolled")]
        public bool IsEnrolled { get; set; }

        [JsonPropertyName("YearsEnrolled")]
        public int YearsEnrolled { get; set; }

        [JsonPropertyName("address1")]
        public Address Address1 { get; set; }

        [JsonPropertyName("address2")]
        public Address Address2 { get; set; }

        [JsonPropertyName("phoneNumbers")]
        public List<Phone> PhoneNumbers = new List<Phone>();

        public string listPhone(List<Phone> phoneNumbers)
        {
            foreach(Phone phone in phoneNumbers)
            {
                return phone.ToString();
            }
            return "";
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Enrolled? {this.IsEnrolled.ToString()} Years Enrolled: {this.YearsEnrolled.ToString()} Address: {this.Address1.ToString()} Phone Numbers: {listPhone(PhoneNumbers)}";
        }
    }
}
