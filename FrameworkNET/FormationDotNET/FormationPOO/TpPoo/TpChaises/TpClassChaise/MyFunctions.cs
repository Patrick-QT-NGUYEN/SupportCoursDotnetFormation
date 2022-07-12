using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpClassChaise.Classes;

namespace TpClassChaise
{
    internal class MyFunctions
    {
        public static void Display(Chaise c)
        {
            Console.WriteLine($"-------------------- Affichage d'un nouvel objet --------------------\n" +
                $"Je suis une chaise, avec {c.NbPieds} pieds en {c.Materiaux} et de couleur {c.Couleur}.\n" +
                   $"---------------------------------------------------------------------\n");
        }
    }
}
