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
        bool ok = false;

        public void Start()
        {
            #region Récupération du nombre d'essais souhaité par l'utilisateur
            while (!ok)
            {
                Console.Write("Combien d'essais souhaitez-vous pour la partie ? :");
                if (int.TryParse(Console.ReadLine(), out int nb))
                {
                    lePendu = new LePendu(nb);
                    ok = true;
                    Console.Clear();
                }
                else
                    Console.WriteLine("\tErreur de saisie, veuillez entrer un entier !");
            }
            #endregion

            #region Jeu du Pendu
            while (lePendu.NbEssai > 0)
            {
                // Affichage du menu dans la console
                Menu(lePendu);
                // Récupération de la lettre de l'utilisateur
                PickChar(lePendu);
                // Test si la partie est gagnée
                if (lePendu.TestWin())
                {
                    Win(lePendu);

                    Exit();
                }

                WaitUser();
            }
            Loose(lePendu);



            #endregion
        }

        private static void Menu(LePendu p)
        {
            Console.WriteLine("--------- Le Jeu du Pendu ---------\n");
            Console.WriteLine($" Le mot à trouver : {p.Masque}");
            Console.WriteLine($" Il vous reste : {p.NbEssai} essais.");            
        }

        private static void PickChar(LePendu p)
        {
            
            Console.Write("Veuillez saisir une lettre : ");
            try
            {
                p.UserWord = Console.ReadLine();
                if (p.TestChar(Convert.ToChar(p.UserWord)))
                    OnCyan("Bravo, vous avez trouvé une lettre");
                else
                    OnRed("Et non... la lettre n'est pas présente dans le mot!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //while (!char.TryParse(Console.ReadLine(), out p.UserWord))
            //    OnRed("Erreur, veuillez saisir une lettre!\n");

            
        }

        private static void OnRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WaitUser()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer ...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Loose(LePendu p)
        {
            OnRed($"\nVous avez perdu...\n");
            Console.WriteLine($"Le mot à trouver était : {p.MotAtrouve}\n");
        }

        private static void Win(LePendu p)
        {
            OnGreen($"\n**********************************************\n" +
                $"Vous avez gagné ! \n\n\t Il vous restait {p.NbEssai} coups! \n\n Le mot à trouver était : {p.MotAtrouve}" +
                $"\n**********************************************\n");
        }

        private static void Exit()
        {
            Console.WriteLine("Appuyez sur ENTER pour fermer le programme ...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
