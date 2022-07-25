using System;
using TpInterfaceIAnimal.Interfaces;


namespace TpInterfaceIAnimal.Classes
{
    class Chien : IAnimal
    {
        public void Crier()
        {
            Console.WriteLine("Le chien aboye");
        }

        public void Manger()
        {
            Console.WriteLine("Le chien qui mange des os");
        }
    }
}
