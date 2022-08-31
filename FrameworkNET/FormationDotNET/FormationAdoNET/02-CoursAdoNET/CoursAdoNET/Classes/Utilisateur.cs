using CoursAdoNET.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoursAdoNET.Classes
{
    internal class Utilisateur
    {
        private int id;
        private string login;
        private string password;
        private MD5 md5Hash;

        public Utilisateur()
        {

        }

        public Utilisateur(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public bool Add()
        {
            // Connexion a la BDD
            SqlConnection connection = Connection.New;

            // Préparation de la requete
            string request = "INSERT INTO UTILISATEUR (LOGIN, PASSWORD) VALUES (@Login, @Password)";

            // Création de l'objet command
            SqlCommand command = new SqlCommand(request,connection);

            // Instanciation de la méthode CREATE MD5
            md5Hash = MD5.Create();

            // Hachage du mot de passe
            string MdpHash = GetMd5Hash(md5Hash, Password);

            // Ajout de params à la requête
            command.Parameters.Add(new SqlParameter("Login", Login));
            command.Parameters.Add(new SqlParameter("Password", MdpHash));

            // Execution de la commande
            connection.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            return true;
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
