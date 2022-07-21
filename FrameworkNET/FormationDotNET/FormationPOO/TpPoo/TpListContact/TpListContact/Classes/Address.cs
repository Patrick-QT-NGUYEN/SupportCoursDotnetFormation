using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListContactClass.Classes
{
    public class Address
    {
        private int id;
        private int number;
        private string roadName;
        private int postalCode;
        private string town;
        private string country;
        private static int instanceCounter = 0;

        public Address()
        {
            ++instanceCounter;
        }
        public Address(int number, string roadName, int postalCode, string town, string country)
        {
            Id = instanceCounter;
            Number = number;
            RoadName = roadName;
            PostalCode = postalCode;
            Town = town;
            Country = country;
        }

        public int Id { get => id; init => id = value; }
        public int Number { get => number; set => number = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public int PostalCode { get => postalCode; set => postalCode = value; }
        public string Town { get => town; set => town = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString()
        {
            return $"{Number} {RoadName} - {PostalCode} {Town} - {Country} ";
        }
    }
}
