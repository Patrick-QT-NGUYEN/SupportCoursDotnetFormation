using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueHeritageClass.Classes
{
    public class Banque
    {
        private static List<Compte> comptes = new();

        //public Banque()
        //{
        //    comptes = new List<Compte>();
        //}

        public static List<Compte> Comptes { get => comptes;  }

        public static bool AjouterCompte(Compte c)
        {
            int nb1 = Comptes.Count;
            comptes.Add(c);
            int nb2 = Comptes.Count;
            return nb2 - nb1 == 1;
        }

        public static Compte RechercherCompte(int id)
        {
            return comptes.Find(compte => compte.Id == id);
        }

    }
}
