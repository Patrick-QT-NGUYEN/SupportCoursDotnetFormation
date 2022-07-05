using System;

namespace Exercice10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Avec plusieurs conditions
            Console.WriteLine("--- La lettre est-elle une voyelle ? --- \n");
            Console.Write("Entrez une lettre : ");
            string lettre = Console.ReadLine().ToUpper();
            if (lettre == "A" || lettre == "E" || lettre == "I"|| lettre == "O" || lettre == "U" || lettre == "Y")
                Console.WriteLine("Cette lettre est une voyelle !\n");
            else
                Console.WriteLine("Cette lettre est une consonne !\n");
            #endregion

            #region Avec contains
            Console.WriteLine("--- La lettre est-elle une voyelle ? --- \n");
            Console.Write("Entrez une lettre : ");
            string lettre2 = Console.ReadLine().ToUpper();
            string voyelle = "AEIOUY";
            if (voyelle.Contains(lettre2))
                Console.WriteLine("Cette lettre est une voyelle !\n");
            else
                Console.WriteLine("Cette lettre est une consonne !\n");
            #endregion

            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
            
        }
    }
}
