using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListContactAdoNET.Classes
{
    public class Person
    {
        private int id;
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;
        private static int instanceCounter = 0;

        public Person()
        {
            ++instanceCounter;
        }

        public Person(string firstname, string lastname, DateTime dateOfBirth) : this()
        {
            Id = instanceCounter;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get => id; init => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public override string ToString()
        {
            return $"\tNom : {Lastname}\tPrénom : {Firstname} \t DateOfBirth : {DateOfBirth.Day}/{DateOfBirth.Month}/{DateOfBirth.Year}";
        }
    }
}
