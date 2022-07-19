
// Déclaration d'une tuple
(double, int) t1 = (4.5, 3);
Console.WriteLine(t1.Item1);
Console.WriteLine(t1.Item2);

// Déclaration d'un tuple avec nom variables
(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}");

// Affichage avec la méthode ToString()
Console.WriteLine(t1.ToString());


Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();