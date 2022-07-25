using System;
using TpInterfaceIAnimal.Interfaces;

namespace TpInterfaceIAnimal.Classes
{
    class Lapin : IAnimal
    {
        public void Crier()
        {
            Console.WriteLine("Le lapin est muet");
        }

        public void Manger()
        {
            Console.WriteLine("Le lapin qui mange des carottes");
        }
    }
}
