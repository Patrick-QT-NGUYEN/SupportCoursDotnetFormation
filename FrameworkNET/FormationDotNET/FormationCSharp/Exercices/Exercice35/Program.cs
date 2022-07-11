﻿
#region Déclaration des variables
string[] persons;
string choixMenu;
int nbContact;
#endregion

Console.WriteLine("======= Gestion des Contacts ========");
Console.Write("Merci de saisir le nombre de contact : ");
nbContact = Convert.ToInt32(Console.ReadLine());
persons = new string[nbContact];
Console.Clear();
do
{
    Console.WriteLine("----- Ma liste de contacts -----");
    Console.WriteLine("1----Saisir des contacts");
    Console.WriteLine("2----Afficher mes contacts");
    Console.WriteLine("0----Quitter\n");
    Console.Write("Faites votre choix : ");

    choixMenu = Console.ReadLine();
    Console.Clear();
    switch (choixMenu)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ Saisir les contacts ------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write("Nom et prénom du contact N° " + (i + 1) + " : ");
                persons[i] = Console.ReadLine();
            }
            Console.Clear();
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ Affichage des contacts ------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("\t-Contact N° " + (i + 1) + " : " + persons[i]);
            }
            break;

        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur Menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();
            break;
    }
} while (choixMenu != "0");



Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();