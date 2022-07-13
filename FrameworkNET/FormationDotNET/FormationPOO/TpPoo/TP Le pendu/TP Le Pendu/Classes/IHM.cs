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
        bool ok = false;
        public void Start()
        {

            #region Récupération du nombre d'essais souhaité par l'utilisateur
            while (!ok)
            {
                Console.Write("Combien d'essais souhaitez-vous pour la partie ?");
                if (int.TryParse(Console.ReadLine(), out int nb))
                {
                    lependu = new LePendu(nb);
                    ok = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\tErreur de saisie, veuillez entrer un entier !");
                }
            }
            #endregion

            #region Jeu du pendu
            while (lependu.NbEssai > 0)
            {
                //Afficher le menu dans la console
                Menu(lependu);
                //Récupération de la lettre de l'utilisateur
                PickChar(lependu);
                //Teste si la partie est gagnée
                if (lependu.TestWin())
                {
                    Win(lependu);
                    Exit();
                }

                WaitUser();
            }
            Loose(lependu);

            #endregion

        }
        private static void Menu(LePendu p)
        {
            Console.WriteLine("-------Le jeu du pendu-------");
            Console.WriteLine($"Le mot à trouver : {p.Masque}");
            Console.WriteLine($"Il vous reste : {p.NbEssai} essai(s)");
        }

        private static void PickChar(LePendu p)
        {
            char lettre = ' ';
            Console.WriteLine("Veuillez saisir une lettre :");
            while (!char.TryParse(Console.ReadLine(), out lettre))
            {
                OnRed("Erreur, veuillez saisir une lettre!\n");
            }
            if (p.TestChar(lettre))
            {
                OnCyan("Bravo, vous avez touvé une lettre");
            }
            else
            {
                OnRed("Et non...la lettre n'est pas présente dans le mot!");
            }
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
            Console.WriteLine("Appuyez sur Entrée pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }
        private static void Loose(LePendu p)
        {
            OnRed($"\nVous avez perdu...\n");
            Console.WriteLine($"Le mot à trouver était {p.MotATrouve}\n");
        }

        private static void Win(LePendu p)
        {
            OnGreen("*************************************************");
            OnGreen($"\nVous avez gagné...\n\n\tIl vous restait {p.NbEssai} coups!");
            Console.WriteLine($"Le mot à trouver était {p.MotATrouve}\n");
            OnGreen("*************************************************");
        }

        private static void Exit()
        {
            Console.WriteLine("Appuyez sur Entrée pour continuer...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
