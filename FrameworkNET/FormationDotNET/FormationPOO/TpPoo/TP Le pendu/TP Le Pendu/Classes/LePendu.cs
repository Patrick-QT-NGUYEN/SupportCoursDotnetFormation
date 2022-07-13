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
            NbEssai = 10;
            MotATrouve = generateur.Generer();
            Masque = GenererMasque();
        }

        public LePendu(int n):this()
        {
            NbEssai = n;   
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
                if (motATrouve[i]==c)
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
                nbEssai--;
            }
            
            return found;


        }

        public bool TestWin()
        {
            return (nbEssai > 0 && motATrouve == masque);
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
