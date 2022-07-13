using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class IHM
    {
        LePendu lePendu;

        public void Start()
        {
           lePendu = new LePendu();
            Console.WriteLine("Debut de l'IHM");
        }
    }
}
