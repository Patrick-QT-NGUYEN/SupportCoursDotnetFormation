
using static LesEnums.Classes.MyEnums;

Saison a = Saison.Hiver;
Console.WriteLine($"La valeur numérique de {a} est {(int)a}");

var b = (Saison)1;
Console.WriteLine(b);

var c = (Saison)0;
Console.WriteLine(c);


Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();