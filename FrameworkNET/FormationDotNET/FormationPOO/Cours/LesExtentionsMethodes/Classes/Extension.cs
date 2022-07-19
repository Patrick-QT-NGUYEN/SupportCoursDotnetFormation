using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExtensionsMethodes.Classes
{
    internal static class Extension
    {
        // Extension de méthode est faite à l'aide du mot clé this en premier parametre.
        public static double Additionner(this double a, double b)
        {
            return a + b;
        }
    }
}
