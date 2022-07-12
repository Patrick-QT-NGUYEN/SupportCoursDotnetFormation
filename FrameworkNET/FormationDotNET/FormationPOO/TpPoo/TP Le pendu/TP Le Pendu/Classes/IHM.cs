using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Le_Pendu.Classes
{
    internal class IHM
    {
        LePendu lependu;
        public void Start()
        {

            lependu = new LePendu();


            do
            {
                Console.Clear();
                Console.WriteLine("----- Jeu du pendu -----");
                Console.WriteLine(lependu.Masque);
                Console.Write("Entrez une lettre :");
                char l = Convert.ToChar(Console.Read());
                lependu.TestChar(l);
                if (lependu.TestWin() == true)
                {
                    goto Test;
                }
                    

            } while (true);

            Test:
            Console.WriteLine("Vous avez trouvé le mot mystère");
            Console.WriteLine($"Le mot était :{lependu.MotATrouve}");




        }
        private static void Menu()
        {

        }

        private static void PickChar()
        {

        }

        private static void OnRed(string message)
        {

        }
        private static void OnGreen(string message)
        {

        }
        private static void OnCyan(string message)
        {

        }
        public static void WaitUser()
        {

        }
        public static void Loose()
        {

        }
    }
}
