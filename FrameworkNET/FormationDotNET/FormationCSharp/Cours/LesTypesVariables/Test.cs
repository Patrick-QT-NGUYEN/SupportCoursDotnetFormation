/*
 *  LES TYPES DE VARIABLES
 */

#region Le Type chaîne de caractères (string)
//// Déclaration de la variable
//string prenom;

//// Affectation de valeur à la variable
//prenom = "Anthony";

//// Afficher la valeur de la variable
//Console.WriteLine(prenom);

//// Déclaration et affectation de valeur en une opération
//string prenom2 = "Sébastien";
//prenom = prenom2;
//prenom2 = "Jeanne";


//// Afficher la valeur de la variable
//Console.WriteLine(prenom);
//Console.WriteLine(prenom2);

//// Afficher le type de variables
//Console.WriteLine(prenom.GetType());
//Console.WriteLine(prenom2.GetType());

//// Récupération console type Chaîne (Console.ReadLine())
//Console.Write("Veuillez saisir votre prénom : ");
//prenom= Console.ReadLine();
//Console.WriteLine(prenom);


//// LES CONCATENATIONS DE CHAINES
//Console.WriteLine("Vous avez saisi le prénom : " + prenom + " et j'en mets plus...."); // Concaténation par emploi de l'opérateur +
//Console.WriteLine("Vous avez saisi le prénom : {0} {1} et j'en mets plus....", prenom, prenom2); // Concaténation par Surcharge de méthode WriteLine
//Console.WriteLine($"Vous avez saisi le prénom : {prenom} et j'en mets plus...."); // Concaténation par les littéraux de gabarit
#endregion

#region Les Types Numériques
///*
// * LE TYPE ENTIERS => byte (0 à 255)
// */

//// Déclaration de la variable
//byte myByte;

//// Affectation de valeur à la variable
//myByte = 25;

//// Afficher la valeur de la variable
//Console.WriteLine(myByte);
//Console.WriteLine(myByte.GetType());

//byte myByte2 = 30;
//myByte = myByte2;
//myByte2 = 40;

//Console.WriteLine(myByte);
//Console.WriteLine(myByte2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (Byte) : ");
//myByte2 = Convert.ToByte( Console.ReadLine() );
//Console.WriteLine(myByte);
//Console.WriteLine(myByte.GetType());

///*
// * LE TYPE ENTIERS => Short (-32768 à 32767)
// */

// Déclaration de la variable
short myShort;

// Affectation de valeur à la variable
myShort = 25;

// Afficher la valeur de la variable
Console.WriteLine(myShort);
Console.WriteLine(myShort.GetType());

short myShort2 = 30;
myShort = myShort2;
myShort2 = 40;

Console.WriteLine(myShort);
Console.WriteLine(myShort2);

// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (Byte) : ");
//myShort2 = Convert.ToShort(Console.ReadLine()); // Pas de convertion possible avec les type Short depuis la class Convert
Console.WriteLine(myShort2);
Console.WriteLine(myShort2.GetType());

///*
// * LE TYPE ENTIERS => int (de -2147483648 à 2147483647)
// */

//// Déclaration de la variable
//int age;

//// Affectation de valeur à la variable
//age = 25;

//// Afficher la valeur de la variable
//Console.WriteLine(age);
//Console.WriteLine(age.GetType());

//int age2 = 30;
//age = age2;
//age2 = 40;

//Console.WriteLine(age);
//Console.WriteLine(age2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (int) : ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(age);
//Console.WriteLine(age.GetType());

/*
 * LE TYPE ENTIERS => long (-9223372036854775808 à 9223372036854775807)
 */

//// Déclaration de la variable
//long myLong;

//// Affectation de valeur à la variable
//myLong = 25L;

//// Afficher la valeur de la variable
//Console.WriteLine(myLong);
//Console.WriteLine(myLong.GetType());

//long myLong2 = 30;
//myLong = myLong2;
//myLong2 = 40;

//Console.WriteLine(myLong);
//Console.WriteLine(myLong2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (long) : ");
//myLong = Convert.ToInt32(Console.ReadLine()); // Convertion en Long non suportée par la class Convert
//Console.WriteLine(myLong);
//Console.WriteLine(myLong.GetType());
#endregion



Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();