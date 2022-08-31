using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLePendu.Interfaces;

namespace TpLePendu.Classes
{
    internal class GenerateurMots : IGenerateur
    {
        private string[] mots = new string[] { "amazon", "google", "facebook", "microsoft", "macintosh", "instagram" };

        public string Generer()
        {
            Random rnd = new();           
            return mots[rnd.Next(0, mots.Length)];
        }
    }
}
