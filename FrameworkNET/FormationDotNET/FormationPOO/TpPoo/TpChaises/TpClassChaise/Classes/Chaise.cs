using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpClassChaise.Classes
{
    internal class Chaise
    {
        #region Attibuts (privé = réservé à la classe)
        private int nbPieds;
        private string couleur;
        private string materiaux;
        #endregion

        #region Constructeurs
        public Chaise()
        {

        }

        public Chaise(int nbPieds, string couleur, string materiaux)
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }
        #endregion

        #region Propriétés
        public int NbPieds { get => nbPieds; set => nbPieds = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }
        #endregion

        public void Display()
        {
            Console.WriteLine( $"-------------------- Affichage d'un nouvel objet --------------------\n" +
                $"Je suis une chaise, avec {nbPieds} pieds en {materiaux} et de couleur {couleur}.\n" +
                   $"---------------------------------------------------------------------\n");
        }


        public override string ToString()
        {
            return $"-------------------- Affichage d'un nouvel objet --------------------\n" +
                $"Je suis une chaise, avec { nbPieds } pieds en {materiaux} et de couleur {couleur}.\n" +
                   $"---------------------------------------------------------------------\n";
        }
    }
}
