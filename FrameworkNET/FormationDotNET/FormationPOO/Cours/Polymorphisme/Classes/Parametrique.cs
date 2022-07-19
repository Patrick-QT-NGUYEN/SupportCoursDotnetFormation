using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme.Classes
{
    class Parametrique
    {

        public static int Additionner(int a, int b)
        {
            return a + b;
        }

        public static string Additionner(string a, string b)
        {
            double resultat = Convert.ToDouble(a) + Convert.ToDouble(b);
            return "Le resultat est " + resultat;
        }
    }
}
