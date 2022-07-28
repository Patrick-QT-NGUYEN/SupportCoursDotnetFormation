using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactAdoNET.Tools;

namespace TpListContactAdoNET.Classes
{
    public class Address
    {
        private int id;
        private int number;
        private string roadName;
        private int postalCode;
        private string town;
        private string country;
        private string _request;
        private static SqlCommand _command;
        private static SqlConnection _connection;
        private static SqlDataReader _reader;



        public Address()
        {
            
        }
        public Address(int number, string roadName, int postalCode, string town, string country)
        {            
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


        public Address Get()
        {
            string value = "";
            // Connection
            _connection = Connection.New;
            // Redaction Request
            _request = "";
            // Ajout Params
            _command.Parameters.Add(new SqlParameter("@Alias", value));
            // Execution de la commande

            // Liberations des objets
            _command.Dispose();
            _connection.Close();

            return new Address();
        }

        public int Add()
        {
            return 1;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{Number} {RoadName} - {PostalCode} {Town} - {Country} ";
        }
    }
}
