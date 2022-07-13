using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class LePendu
    {
        #region Attributs
        private int nbEssai;
        private string masque;
        private string motAtrouve;
        private GenerateurMots generateur;
        #endregion

        #region Constructeurs
        public LePendu()
        {
            generateur = new();
            NbEssai = 0;
            MotAtrouve = generateur.Generer();
            Masque = GenererMasque();
        }
        #endregion

        #region Proprietes
        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public string Masque { get => masque; set => masque = value; }
        public string MotAtrouve { get => motAtrouve; set => motAtrouve = value; }
        #endregion

        #region Methodes
        public bool TestChar(char c)
        {
            return true;
        }

        public bool TestWin()
        {
            return true;
        }

        public string GenererMasque()
        {
            string masqueTmp="";
            for (int i = 0; i < MotAtrouve.Length; i++)
                masqueTmp += "*";            
            return masqueTmp;
        }

        #endregion
    }
}
