using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDelegues.Classes
{
    internal class Calculatrice
    {
        //// Déclaration d'un délégué (représentation de la fonction qui sera passé en parametre
        //public delegate double DelegateMethodeCalcule(double a, double b);

        //public void Calculer(double a , double b , DelegateMethodeCalcule Methode)
        //{
        //    Console.WriteLine(Methode(a, b));
        //}

        public void Calculer(double a, double b , Func<double, double,double> Methode)
        {
            Console.WriteLine(Methode(a,b));
        }

        // Deux tyes Générique pour les délégués : Action & Func // Action => Delegué sans retour (void) // Func => Délégué avec retour


        //public delegate void DelegateVoid(string s);

        //public void HowToDisplay(string message , DelegateVoid methode)
        //{
        //    methode(message);
        //} 

        public void HowToDisplay(string message, Action<string> Methode)
        {
            Methode(message);   
        }
    }
}
