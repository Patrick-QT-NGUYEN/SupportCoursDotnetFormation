using TP_Chaise.Classes;

Chaise Chaise_1 = new Chaise();

Chaise_1.NbPieds = 4;
Chaise_1.Materiaux = "Bois";
Chaise_1.Couleur = "Bleue";

//Console.WriteLine(Chaise_1.ToString());
//Chaise_1.Afficher();
Chaise.Display(Chaise_1);

Chaise Chaise_2 = new Chaise(4, "Blanche", "Métal");

//Console.WriteLine(Chaise_2.ToString());
//Chaise_2.Afficher();
Chaise.Display(Chaise_2);

Chaise Chaise_3 = new(1, "Transparente", "Plexiglass");

//Console.WriteLine(Chaise_3.ToString());
//Chaise_3.Afficher();
Chaise.Display(Chaise_3);

Console.WriteLine("Appuyez sur Entrée pour fermer le programme");
Console.Read();