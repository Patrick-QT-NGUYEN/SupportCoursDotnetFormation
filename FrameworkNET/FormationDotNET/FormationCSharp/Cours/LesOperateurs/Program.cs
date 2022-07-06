#region Addition
// Opérateur + avec des entiers
int nb1 = 10, nb2 = 20;
int somme = nb1+ nb2; // 30
Console.WriteLine($"La somme de {nb1} et de {nb2} est égal à {somme}");

// Opérateur combiné
somme += nb2; // 50

// Incrémentation
somme++;
#endregion

#region Soustraction
// Opérateur - avec des entiers
somme = nb2 - nb1; // 10
Console.WriteLine($"{nb2} moins {nb1} est égal à {somme}");

// Opérateur combiné
somme -= nb1; // 0

// Décrémentation
somme--; // -1
#endregion

#region multiplication
// Opérateur * avec des entiers
somme = nb2 * nb1; // 200
Console.WriteLine($"{nb2} multiplié par {nb1} est égal à {somme}");

// Opérateur combiné
somme *= nb1; // 20

#endregion

#region Division
// Opérateur / avec des entiers
somme = nb2 / nb1; // 200
Console.WriteLine($"{nb2} divisé par {nb1} est égal à {somme}");

// Opérateur combiné
somme *= nb1; // 2000

#endregion

#region Modulo (%)
// Opérateur / avec des entiers
somme = nb2 % nb1; // 0
Console.WriteLine($"{nb2} modulo {nb1} est égal à {somme}");

#endregion

Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
