using System;

namespace LaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Affichage dans la console
            // Affichage dans la console sans retour à la ligne
            Console.Write("Bla");
            Console.Write("Bla2");
            Console.Write("Bla3\n");
            // Affichage dans la console avec un retourn à la ligne
            Console.WriteLine("Je retourne à la ligne");
            Console.WriteLine("La preuve!");
            #endregion

            #region Lecture Console
            // Lire un caractère de l'utilisateur => Console.Read()
            //char @char = (char)Console.Read();
            //Console.WriteLine(@char);

            // Lire une chaîne de caractères avec => Console.ReadLine()
            //string Nom = Console.ReadLine();
            //Console.WriteLine(Nom);
            #endregion

            #region Changement de couleur de la police dans la console
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je suis en rouge!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Je suis en vert!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Je suis en Cyan!");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Caractères Spéciaux
            // Affichage d'un chemin dans la console
            Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            Console.WriteLine(@"c:\repertoire\MonFichier.cs");

            // Le \ devant les " 
            Console.WriteLine("Bonjour, je m'appelle \"Anthony\"");

            // Le \n pour un retour à la ligne 
            Console.Write("Je retourne à la ligne après\n");
            Console.WriteLine("Je saute une ligne après\n");

            // Le \t pour les tabulations
            Console.WriteLine("Liste de choses à faire :");
            Console.WriteLine("\t - Apprendre le C#");
            Console.WriteLine("\t - Faire des exercices");
            Console.WriteLine("\t\t - J'ai deux tabulations");

            // Afficher des caractères spéciaux
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("€uro");
            #endregion

            #region Affichage de Date et heures
            DateTime dateHeure = DateTime.Now;
            Console.WriteLine("Date et Heures : {0:d} at {0:t}",dateHeure);
            #endregion


            Console.WriteLine("Appuyez sur une ENTER pour fermer le programme...");
            Console.Read();        
        }
    }
}
