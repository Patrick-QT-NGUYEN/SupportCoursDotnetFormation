using IntroductionPOO.Classes;

// Création d'une instance de la classe Voiture
Voiture voitureDeNicolas = new Voiture();
// Ajout des propriétés de notre objet voiture
voitureDeNicolas.Modele = "Clio";
voitureDeNicolas.Couleur = "Blanche";
voitureDeNicolas.Reservoir = 45;
voitureDeNicolas.Autonomie = 850;

Console.WriteLine("\nVoiture de Nicolas");
// Affchage de l'objet voitureDeNicolas dans la console
Console.WriteLine(voitureDeNicolas);
Console.WriteLine(voitureDeNicolas.Demarrer());
Console.WriteLine(voitureDeNicolas.Klaxonner());
Console.WriteLine(voitureDeNicolas.Rouler());
Console.WriteLine(voitureDeNicolas.Stopper());
Console.WriteLine(voitureDeNicolas.Arreter());
// Console.WriteLine(voitureDeNicolas.ToString());



Console.WriteLine("\nVoiture de Julie");

// Création d'une instance de Voiture par le contructeur à 4 params
Voiture voitureDeJulie = new ("208","Rouge", 40, 800);
Console.WriteLine(voitureDeJulie);

Console.WriteLine(voitureDeJulie.Arreter());
Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Demarrer());
Console.WriteLine(voitureDeJulie.Demarrer());
Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Stopper());
Console.WriteLine(voitureDeJulie.Klaxonner());
Console.WriteLine(voitureDeJulie.Arreter());
Console.WriteLine(voitureDeJulie.Arreter());
Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Stopper());

MyFunctions.Display(voitureDeJulie.ToString());
Console.WriteLine(MyFunctions.compteur); 

Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
