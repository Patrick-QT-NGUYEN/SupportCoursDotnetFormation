using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions.Classes
{
    internal class ExceptionTest
    {
        public static double SafeDivision(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Attention, vous tentez une division par zéro.");
            return a / b;
        }
    }
}
