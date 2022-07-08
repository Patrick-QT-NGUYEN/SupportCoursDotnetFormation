

#region Création d'un tableau d'entiers T1 et itéaration
Console.WriteLine("Création d'un tableau T1 et itération du contenu \n");
int[] T1 = { 1, 2, 3 };

for (int i = 0; i < T1.Length; i++)
    Console.WriteLine(T1[i]);

#endregion

#region Création d'un tableau d'entier T2

Console.WriteLine("\nCréation d'un tableau T2 vide et itération\n");

int[] T2 = new int[10];

for (int i = 0; i < T2.Length; i++)
    Console.WriteLine(T2[i]);

#endregion

#region Clonage de T1 dans T2 

Console.WriteLine("\nClonage de T1 dans T2\n");
T2 = (int[])T1.Clone();

#endregion

#region Modification de T1
Console.WriteLine("\nModification de T1 => T1[0] = 18\n");
T1[0] = 18;
#endregion

#region Affichage des tableaux
Console.WriteLine("\nContenu de T1 apres copie et modification :\n");
for (int i = 0; i < T1.Length; i++)
    Console.WriteLine(T1[i]);



Console.WriteLine("\nContenu de T2 apres copie et modification de T1 :\n");
for (int i = 0; i < T2.Length; i++)
    Console.WriteLine(T2[i]);
#endregion


Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme...");
Console.Read();
