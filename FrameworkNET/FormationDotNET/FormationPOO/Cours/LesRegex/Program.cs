
using LesRegex.Classes;

//string test = "Jeanne5";
//Console.WriteLine(Tools.IsName(test));




// Création d'une personne()
Personne p = new();
p.Firstname = "Anthony";
p.Lastname = "Di Persio";
p.Telephone = "0614859632";
p.Email = "anthony.di-persio@utopios.net";
Console.WriteLine(p);

Console.WriteLine(Tools.FormatPhone("33-6-14-85-96-32"));
Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();