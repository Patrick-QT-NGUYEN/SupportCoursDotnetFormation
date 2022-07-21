using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListContactClass.Classes
{
    public class Annuaire
    {
        List<Contact> contacts;

        public Annuaire()
        {
            Contacts = new();
        }

        public List<Contact> Contacts { get => contacts; set => contacts = value; }
    }
}
