using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactClass.Tools;

namespace TpListContactClass.Classes
{
    public class Contact : Person
    {
        private int contactId;
        private Address contactAddress;
        private string phoneNumber;
        private string email;
        private static int instanceCounter = 0;


        public Contact()
        {
            ContactId = ++instanceCounter;
        }
        public Contact(string firstname, string lastname, DateTime dateOfBirth, Address contactAddress, string phoneNumber, string email) : base(firstname, lastname, dateOfBirth)
        {
            ContactId = ++instanceCounter;
            ContactAddress = contactAddress;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public int ContactId { get => contactId; init => contactId = value; }
        public Address ContactAddress { get => contactAddress; set => contactAddress = value; }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (MyRegex.IsPhone(value))
                    phoneNumber = value;
                else
                    throw new FormatException("Erreur format Télephone.");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (MyRegex.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur format Email.");
            }
        }

        public override string ToString()
        {
            return $"\n Contact N°{ContactId}\n{base.ToString()}\n\tAdresse : {ContactAddress} \n\tPhone : {PhoneNumber} \n\tEmail : {Email}\n";
        }
    }
}
