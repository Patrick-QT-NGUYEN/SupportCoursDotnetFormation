// See https://aka.ms/new-console-template for more information

using TpBanqueHeritageClass.Classes;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Compte c = new ();
c.Solde = 200.00M;
//Console.WriteLine(c.Id);
Client client = new();
client.Nom = "Di Persio";
client.Prenom = "Anthony";
client.Telephone = "+33 6 41 52 78 96";

//Console.WriteLine(client);

c.ClientBanque = client;
Console.WriteLine(c);

Operation o1 = new(350.00M);
Operation o2 = new(-150.00M);
Operation o3 = new(30.00M);
//c.Operations.Add(o1);
//c.Operations.Add(o2);
//c.Operations.Add(o3);

c.Depot(o1);
c.Retrait(o2);
c.Depot(o3);


Console.WriteLine(c);





c.AjouterCompte();

//Compte autreCompte = Banque.RechercherCompte(1);
//Console.WriteLine(autreCompte);




Console.WriteLine("Appuyez sur ENter pour fermer...");
Console.Read();
