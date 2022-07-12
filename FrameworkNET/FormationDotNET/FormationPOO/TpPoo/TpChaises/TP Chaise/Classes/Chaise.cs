using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Chaise.Classes
{
    internal class Chaise
    {
        private int nbPieds;
        private string couleur;
        private string materiaux;

        public Chaise()
        {

        }

        public Chaise(int nbPieds, string couleur, string materiaux)
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }

        public int NbPieds { get => nbPieds; set => nbPieds = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }

        //public override string ToString()
        //{
        //    string pied = "pied";
        //    if (nbPieds > 1)
        //        pied = "pieds";

        //    return $"\n----------------------------Ajout d'un nouvel objet----------------------------\n"
        //    +$"\nJe suis une chaise avec {nbPieds} {pied} en {materiaux} et de couleur {couleur}\n"
        //    + "\n-------------------------------------------------------------------------------\n";

        //}

        public void Afficher()
        {
            string pied = "pied";
            if (nbPieds > 1)
                pied = "pieds";

            Console.WriteLine($"\n----------------------------Ajout d'un nouvel objet----------------------------\n");
            Console.WriteLine($"Je suis une chaise avec {nbPieds} {pied} en {materiaux} et de couleur {couleur}");
            Console.WriteLine("-------------------------------------------------------------------------------\n");
        }

        public static void Display(Chaise c)
        {
            string pied = "pied";
            if (c.nbPieds > 1)
                pied = "pieds";

            Console.WriteLine($"\n----------------------------Ajout d'un nouvel objet----------------------------\n");
            Console.WriteLine($"\nJe suis une chaise avec {c.nbPieds} {pied} en {c.materiaux} et de couleur {c.couleur}\n");
            Console.WriteLine("\n-------------------------------------------------------------------------------\n");

        }


    }
}
