using System;
using TpInterfaceIAnimal.Interfaces;

namespace TpInterfaceIAnimal.Classes
{
    class Chat : IAnimal
    {
        public void Crier()
        {
            Console.WriteLine("Le chat miaule");
        }

        public void Manger()
        {
            Console.WriteLine("Le chat qui mange des croquettes");
        }
    }
}
