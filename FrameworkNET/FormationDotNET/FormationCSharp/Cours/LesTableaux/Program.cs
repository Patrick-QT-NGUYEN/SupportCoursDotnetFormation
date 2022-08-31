// See https://aka.ms/new-console-template for more information

#region Création d'un tableau et assignation de valeur string
Console.WriteLine("Tableau de string\n");
string[] prenoms;
prenoms = new string[5];

for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

prenoms[0] = "Anthony";
prenoms[1] = "Yves";
prenoms[2] = "Charles";
prenoms[3] = "Marie";
prenoms[4] = "Charles";

for (int i = 0; i < prenoms.Length; i++)
    Console.WriteLine($"A l'index {i} : {prenoms[i]}");

#endregion

#region Création d'un tableau et assignation de valeur int
Console.WriteLine("\nTableau de int\n");

int[] nombres;
nombres = new int[5];

for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

nombres[0] = 1;
nombres[1] = 5;
nombres[2] = 3;
nombres[3] = 2;
nombres[4] = 4;

for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

#endregion

#region Création d'un tableau et assignation d'objet
Console.WriteLine("\nTableau d'objets\n");

object[] tabs;
tabs = new object[5];

for (int i = 0; i < tabs.Length; i++)
    Console.WriteLine($"A l'index {i} : {tabs[i]}");

tabs[0] = 12;
tabs[1] = 1.56;
tabs[2] = "Message";
tabs[3] = true;
tabs[4] = 45.87F;

for (int i = 0; i < tabs.Length; i++)
    Console.WriteLine($"A l'index {i} : {tabs[i]}");

#endregion

#region Création et initialisation en même temps
Console.WriteLine("\nTableau de double\n");
double[] nombres2 = { 2.2, 3.3, 4.4 };


for (int i = 0; i < nombres2.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres2[i]}");
#endregion

#region Utilisation de la méthode Sort() pour trier un tableau en ordre croissant

Console.WriteLine("\nTri d'un Tableau (Sort())\n");
for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

Array.Sort(nombres);

for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

#endregion

#region Utilisation de la méthode Reverse() pour inverser un tableau

Console.WriteLine("\n Inverser un Tableau (Reverse())\n");


Array.Reverse(nombres);

for (int i = 0; i < nombres.Length; i++)
    Console.WriteLine($"A l'index {i} : {nombres[i]}");

#endregion

#region Utilisation de la méthod IndexOf() pour retourner l'index d'une valeur
Console.WriteLine("\n Rechercher la postion d'une entité (IndexOf())\n");

int index = Array.IndexOf(prenoms, "Charles");
Console.WriteLine($"L'index du prénom \"Charles\" est {index}.");
#endregion

#region Utilisation de la méthod IndexOf() pour retourner l'index d'une valeur
Console.WriteLine("\n Rechercher la derniere postion d'une entité (LastIndexOf())\n");

int index2 = Array.LastIndexOf(prenoms, "Charles");
Console.WriteLine($"L'index du prénom \"Charles\" est {index2}.");
#endregion

Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme...");
Console.Read();