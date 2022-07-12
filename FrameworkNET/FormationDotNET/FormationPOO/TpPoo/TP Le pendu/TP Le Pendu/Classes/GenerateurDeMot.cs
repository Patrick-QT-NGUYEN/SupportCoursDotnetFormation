using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Le_Pendu.Classes
{
    internal class GenerateurDeMot
    {
        private string[] ListeMots = new string[] { "amazon", "google", "facebook", "uber", "anticonstitutionnellement", "dictonnaire", "instagram" };

        public string Generer()
        {
            Random rnd = new Random();
            return ListeMots[rnd.Next(0, ListeMots.Length)];
        }
        

    }
}
