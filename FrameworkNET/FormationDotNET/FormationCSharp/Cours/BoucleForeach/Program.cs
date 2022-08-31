
#region Foreach avec données type int
Console.WriteLine("Creation d'un tableau T1");
int[] T1 = { 1, 2, 3 };
Console.WriteLine("Contenu de T1 : ");
foreach (int nombre in T1)
{
    Console.WriteLine(nombre);
}
#endregion

#region Foreach avec données type string
Console.WriteLine("Creation d'un tableau T2");
string[] T2 = { "1", "2", "3" };
Console.WriteLine("Contenu de T2 : ");
foreach (string nb in T2)
{
    Console.WriteLine(nb);
}
#endregion

Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();