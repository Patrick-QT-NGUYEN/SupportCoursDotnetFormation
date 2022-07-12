using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Le_Pendu.Classes
{
    internal class LePendu
    {
        private int nbEssai;
        private string masque;
        private string motATrouve;
        private GenerateurDeMot generateur;

        public LePendu()
        {
            generateur = new();
            NbEssai = 0;
            MotATrouve = generateur.Generer();
            Masque = GenererMasque();
        }

        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public string Masque { get => masque; set => masque = value; }
        public string MotATrouve { get => motATrouve; set => motATrouve = value; }

        public bool TestChar(char c)
        {

            bool found = false;
            string masqueTmp = "";
            for (int i = 0; i < motATrouve.Length; i++)
            {
                if (MotATrouve[i]==c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                {
                    masqueTmp += masque[i];
                }
            }
            masque = masqueTmp;
            if(!found)
            {
                NbEssai++;
            }
            return found;


        }

        public bool TestWin()
        {

            return (NbEssai > 0 && MotATrouve == Masque);
        }

        public string GenererMasque()
        {
            string masqueTmp = "";
            for (int i = 0; i < motATrouve.Length; i++)
            {
                masqueTmp += "*";
            }
            return masqueTmp;
        }

    }
}
