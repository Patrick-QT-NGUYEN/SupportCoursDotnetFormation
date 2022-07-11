using IntroductionPOO.Classes;

//Creation d'un instance de la classe Voiture
Voiture voitureDeNicolas = new Voiture();
//Ajout des propriétés de notre objet voiture
voitureDeNicolas.Modele = "Clio";
voitureDeNicolas.Couleur = "Blanche";
voitureDeNicolas.Reservoir = 45;
voitureDeNicolas.Autonomie = 850;

//Affichage de l'objet voitureDeNicolas
Console.WriteLine(voitureDeNicolas);
Console.WriteLine(voitureDeNicolas.Demarrer());
Console.WriteLine(voitureDeNicolas.Rouler());
Console.WriteLine(voitureDeNicolas.Arreter());
Console.WriteLine(voitureDeNicolas.Stopper());
Console.WriteLine(voitureDeNicolas.Arreter());

Console.WriteLine("*******************************************");
//Creation d'une instance de Voiture par le constructeur à 4 params
Voiture voitureDeJulie = new Voiture("208", "Grise", 40, 800);
//Voiture voitureDeJulie = new ("208", "Grise", 40, 800);
Console.WriteLine(voitureDeJulie);
Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Demarrer());
Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Stopper());
Console.WriteLine(voitureDeJulie.Klaxonner());
Console.WriteLine(voitureDeNicolas.Arreter());
Console.WriteLine(voitureDeNicolas.Arreter());
Console.WriteLine(voitureDeNicolas.Stopper());
Console.WriteLine(voitureDeJulie.Rouler());

MyFunctions.Display(voitureDeJulie.ToString());
Console.WriteLine(MyFunctions.compteur);

Console.WriteLine("Appuyez sur Entrée pour fermer le programme");
Console.Read();