using LesGeneriques.Classes;

#region Class Opération<T>

Console.WriteLine("***** Les Elements Génériques *****");
Console.WriteLine("Avec le type int");
Operation<int> obj1 = new();
Console.WriteLine(obj1.EstEquivalent(2,1));
Console.WriteLine("Avec le type double");
Operation<double> obj2 = new();
Console.WriteLine(obj2.EstEquivalent(2.23, 2.23));
Console.WriteLine("Avec le type string");
Operation<string> obj3 = new();
Console.WriteLine(obj3.EstEquivalent("Bonjours", "Bonjour"));

#endregion

#region Les Queues<T> FIFO (First in, First Out)
Console.WriteLine("***** La class Queue<T> *****");
Console.WriteLine("Avec le type int : ");
Queue<int> file = new Queue<int>();
file.Enqueue(1);
file.Enqueue(2);
file.Enqueue(3);
file.Enqueue(4);

int valeur = file.Dequeue();
Console.WriteLine(valeur);
valeur = file.Dequeue();
Console.WriteLine(valeur);
valeur = file.Dequeue();
Console.WriteLine(valeur);
valeur = file.Dequeue();
Console.WriteLine(valeur);

Console.WriteLine("Avec le type string : ");
Queue<string> file2 = new Queue<string>();
file2.Enqueue("Chaine 1");
file2.Enqueue("Chaine 2");
file2.Enqueue("Chaine 3");
file2.Enqueue("Chaine 4");


string chaine = file2.Dequeue();
Console.WriteLine(chaine);
chaine = file2.Dequeue();
Console.WriteLine(chaine);
chaine = file2.Dequeue();
Console.WriteLine(chaine);
chaine = file2.Dequeue();
Console.WriteLine(chaine);

#endregion

#region Pile<T> LIFO (Last in, First Out)

Console.WriteLine("***** Les Pile<T> *****");
Console.WriteLine("Avec le type int : ");
Pile<int> pileEntier = new Pile<int>(3);
pileEntier.Empiler(1);
pileEntier.Empiler(25);
pileEntier.Empiler(55);
pileEntier.Empiler(145);
Console.WriteLine($"L'element en place n° 1 de la pile est {pileEntier.Get(0)}");
Console.WriteLine($"L'element en place n° 2 de la pile est {pileEntier.Get(1)}");
Console.WriteLine($"L'element en place n° 3 de la pile est {pileEntier.Get(2)}");
pileEntier.Depiler();
Console.WriteLine($"L'element en place n° 3 de la pile est {pileEntier.Get(2)}");
Console.WriteLine($"L'element en place n° 2 de la pile est {pileEntier.Get(1)}");
pileEntier.Depiler();
Console.WriteLine($"L'element en place n° 2 de la pile est {pileEntier.Get(1)}");
Console.WriteLine($"L'element en place n° 1 de la pile est {pileEntier.Get(0)}");

Console.WriteLine("***** Les Pile<T> *****");
Console.WriteLine("Avec le type Voiture : ");
Pile<Voiture> pileVoiture = new Pile<Voiture>(3);
pileVoiture.Empiler(new Voiture("ceed","verte",30,800));
pileVoiture.Empiler(new Voiture("kuga", "noir", 40, 900));
pileVoiture.Empiler(new Voiture("kangoo", "blanc", 45, 850));
pileVoiture.Empiler(new Voiture("A3", "Grise", 50, 600));
Console.WriteLine($"L'element en place n° 1 de la pile est {pileVoiture.Get(0)}");
Console.WriteLine($"L'element en place n° 2 de la pile est {pileVoiture.Get(1)}");
Console.WriteLine($"L'element en place n° 3 de la pile est {pileVoiture.Get(2)}");
pileVoiture.Depiler();
Console.WriteLine($"L'element en place n° 3 de la pile est {pileVoiture.Get(2)}");
Console.WriteLine($"L'element en place n° 2 de la pile est {pileVoiture.Get(1)}");
pileVoiture.Depiler();
Console.WriteLine($"L'element en place n° 2 de la pile est {pileVoiture.Get(1)}");
Console.WriteLine($"L'element en place n° 1 de la pile est {pileVoiture.Get(0)}");
#endregion

#region Les Dictionnaires 
Console.WriteLine("***** Les Dictionnaires<T> *****");
Console.WriteLine("Avec le type Personne : ");
Dictionary<string, Personne> annuaire = new Dictionary<string, Personne>();
annuaire.Add("06 01 02 03 04",new Personne { Prenom = "Nicolas" , Telephone= "06 01 02 03 04" });
annuaire.Add("06 98 87 65 41",new Personne { Prenom = "Jeanne",Telephone = "06 98 87 65 41" });

Personne p = annuaire["06 01 02 03 04"];
Console.WriteLine(p);
#endregion

#region Les List<T>
Console.WriteLine("***** Les List<T> *****");
// INT
Console.WriteLine("Avec le type INT : ");
List<int> listeEntiers = new ();
listeEntiers.Add(10);
listeEntiers.Add(20);
listeEntiers.Add(30);
Console.WriteLine($"La liste contient {listeEntiers.Count} entiers");
Console.WriteLine($"======== Contenu de la liste d'entiers ========");
foreach (int i in listeEntiers)
    Console.WriteLine(i);
Console.WriteLine($"===============================================");

// Voiture
Console.WriteLine("Avec le type Voiture : ");
List<Voiture> listeVoiture = new();
listeVoiture.Add(new Voiture("ceed", "verte", 30, 800));
listeVoiture.Add(new Voiture("kuga", "noir", 40, 900));
listeVoiture.Add(new Voiture("kangoo", "blanc", 45, 850));
Console.WriteLine($"La liste de voiture contient {listeVoiture.Count} voitures");
Console.WriteLine($"======== Contenu de la liste de voiture ========");
foreach (Voiture v in listeVoiture)
    Console.WriteLine(v);
Console.WriteLine($"===============================================");


#endregion

Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();