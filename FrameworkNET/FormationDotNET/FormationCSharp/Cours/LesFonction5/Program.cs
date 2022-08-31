using System;

namespace LesFonction5
{
    internal class Program
    {
        static string resultat;
        public static void Main(string[] args)
        {
            Bonjour();
            Bonjour("Di Persio", "Anthony");
            Console.WriteLine("Le résultat est : "+Additionner(3,5));
            Display("C'est génial les fonctions!");
            //Console.Write("Veuillez saisir votre nom : ");
            //string nom = Console.ReadLine();
            //Console.Write("Veuillez saisir votre prénom : ");
            //string prenom = Console.ReadLine();
            //Console.Write("Veuillez saisir votre age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Display(nom, prenom, age);
            Console.WriteLine(resultat);
            Console.Read();
        }

        // Déclaration d'une fonction sans params
        public static void Bonjour()
        {
            Console.WriteLine("Bonjour!");
        }
        public static void Bonjour(string nom,string prenom)
        {
            Console.WriteLine($"Bonjour {nom} {prenom}!");
        }
        public static int Additionner(int nb1,int nb2)
        {
            int Resultat = nb1 + nb2;
            return Resultat;
        }
       
        public static void Display(string chaine)
        {
            Console.WriteLine(chaine);
        }

        public static void Display(string nom, string prenom,int age)
        {
            Console.WriteLine($"Bonjour {nom} {prenom}, vous avez {age} ans.");
        }
    }
}
