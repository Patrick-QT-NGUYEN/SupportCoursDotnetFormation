using TpClassChaise;
using TpClassChaise.Classes;

#region Chaise1

// Instanciation d'une chaise 1
Chaise chaise1 = new();

// Affectation des propriétés de la chaise1
chaise1.NbPieds = 4;
chaise1.Materiaux = "Bois";
chaise1.Couleur = "Bleu";

Console.WriteLine(chaise1);
#endregion

#region Chaise2
Chaise chaise2 = new(4,"Blanche","Métal");

// Utilisation de la méthode Display présente dans la class Chaise
chaise2.Display();

#endregion

#region Chaise3
Chaise chaise3 = new(1, "Pléxiglass", "Transparente");

// Utilisation de la méthode Display de la class MyFunction
MyFunctions.Display(chaise3);
#endregion



Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
