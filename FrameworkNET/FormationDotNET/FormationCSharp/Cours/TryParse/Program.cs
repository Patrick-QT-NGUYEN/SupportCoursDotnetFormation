// See https://aka.ms/new-console-template for more information
// string chaine = "20";
string chaine = "vingt";
int age;
bool result = int.TryParse(chaine, out age);

if (int.TryParse(chaine, out age))
    Console.WriteLine($"La convertion est possible, age vaut {age}");
else
    Console.WriteLine($"La convertion est impossible");


Console.WriteLine(result);
Console.WriteLine(age);


Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();