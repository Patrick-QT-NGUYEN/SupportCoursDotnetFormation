using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Oiseau : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris... comme je peux!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je decolle depuis la branche d'un arbe...");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole grace à mes battements d'ailes");
        }
    }
}
