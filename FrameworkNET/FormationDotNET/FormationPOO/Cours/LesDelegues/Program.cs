
using LesDelegues.Classes;

Calculatrice c = new Calculatrice();
// Utilisation du delegate avec la méthode addition (ci-dessous)
c.Calculer(10, 20, Addition);

// Utilisation du delegate avec une méthode de soustraction anonyme (expression lambda)
c.Calculer(30, 40, delegate (double a, double b) { return a - b; });

// Utilisation du delegate avec une méthode de multiplication anonyme (expression lambda)
c.Calculer(30, 40, (double a, double b) => { return a * b; });

// Si il n'y a qu'une seule instruction les accolades sont facultative
c.Calculer(30, 40, (a, b) => a / b);

// Utilisation du Delegate Action (Sans retour)
c.HowToDisplay("Salut !", AfficherPlus);

// Utilisation d'un délégué pour l'affichage d'une chaine
c.HowToDisplay("Salut",Afficher);







// Création des fonctions à utiliser en parametre ...
double Addition(double a , double b){ return a + b;}
double Soustraction(double a , double b){ return a - b;}

void Afficher(string s) { Console.WriteLine(s); }
void AfficherPlus(string s) { Console.WriteLine(s+"... et j'en affiche plus!"); }


Console.WriteLine("Appuyez sur ENTER pour fermer...");
Console.Read();
