using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class LePendu
    {
        #region Attributs
        private int nbEssai;
        private string masque;
        private string motAtrouve;
        private string userWord;
        private GenerateurMots generateur;
        Regex regex = new Regex(@"^[a-zA-Zéèë]{1}$");
        #endregion

        #region Constructeurs
        public LePendu()
        {
            generateur = new();
            NbEssai = 10;
            MotAtrouve = generateur.Generer();
            Masque = GenererMasque();
        }

        public LePendu(int n) : this()
        {
            NbEssai = n;
        }
        #endregion

        #region Proprietes
        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public string Masque { get => masque; set => masque = value; }
        public string MotAtrouve { get => motAtrouve; set => motAtrouve = value; }
        public string UserWord
        {
            get => userWord;
            set
            {
                Match match = regex.Match(value);
                if (match.Success)
                {
                    userWord = value;
                }
                else
                    throw new FormatException("Erreur format du mot utilisateur...");
            }
        }
        #endregion

        #region Methodes
        public bool TestChar(char c)
        {
            bool found = false;
            string masqueTmp = "";
            for (int i = 0; i < MotAtrouve.Length; i++)
            {
                if (MotAtrouve[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                    masqueTmp += masque[i];
            }
            masque = masqueTmp;
            if (!found)
                NbEssai--;

            return found;
        }

        public bool TestWin()
        {
            return (NbEssai > 0 && MotAtrouve == Masque);
        }

        public string GenererMasque()
        {
            string masqueTmp = "";
            for (int i = 0; i < MotAtrouve.Length; i++)
                masqueTmp += "*";
            return masqueTmp;
        }

        #endregion
    }
}
