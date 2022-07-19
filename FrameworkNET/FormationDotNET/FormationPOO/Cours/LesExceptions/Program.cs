using LesExceptions.Classes;

double a = 0, b = 0, result = 0;

Console.WriteLine("--------------- LES EXCEPTIONS -----------------");

Console.Write("Veuillez saisir un premier nombre : ");

while (!double.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("\nErreur de saisie, veuillez entrer un nombre!");

Console.Write("Veuillez saisir un deuxieme nombre : ");

while (!double.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("\nErreur de saisie, veuillez entrer un nombre!");

try
{
    result = ExceptionTest.SafeDivision(a, b);
    Console.WriteLine($"{a} divisé par {b} est égal à {result}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Je m'execute quelque soit l'issue du Try/Catch");
}

Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();