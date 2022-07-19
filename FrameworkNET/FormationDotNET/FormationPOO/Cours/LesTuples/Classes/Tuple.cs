using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesTuples.Classes
{
    internal class Tuple
    {
        public (int, string, bool) GetTuple()
        {
            // logique métier
            return (10, "Toto", true);
        }
    }
}
