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

//// Déclaration de la variable
//short myShort;

//// Affectation de valeur à la variable
//myShort = 25;

//// Afficher la valeur de la variable
//Console.WriteLine(myShort);
//Console.WriteLine(myShort.GetType());

//short myShort2 = 30;
//myShort = myShort2;
//myShort2 = 40;

//Console.WriteLine(myShort);
//Console.WriteLine(myShort2);

//// Lecture de saisie utilisateur
////Console.Write("Veuillez saisir votre age (Byte) : ");
////myShort2 = Convert.ToShort(Console.ReadLine()); // Pas de convertion possible avec les type Short depuis la class Convert
//Console.WriteLine(myShort2);
//Console.WriteLine(myShort2.GetType());

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

#region LES TYPES DECIMAUX
///*
// * LE TYPE DECIMAL => Float (-3,402823e38 à 3,402823e38 )
// */

//// Déclaration de la variable
//float myFloat;

//// Affectation de valeur à la variable
//myFloat = 25.41F;

//// Afficher la valeur de la variable
//Console.WriteLine(myFloat);
//Console.WriteLine(myFloat.GetType()); // Single

//float myFloat2 = 30.41F;
//myFloat = myFloat2;
//myFloat2 = 40.41F;

//Console.WriteLine(myFloat);
//Console.WriteLine(myFloat2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (float) : ");
//// myFloat = Convert.ToDouble(Console.ReadLine()); // Convertion en Float non suportée par la class Convert
//Console.WriteLine(myFloat);
//Console.WriteLine(myFloat.GetType());

///*
// * LE TYPE DECIMAL => Double (-1,79769313486232e308 à 1,79769313486232e308 )
// */

//// Déclaration de la variable
//double myDouble;

//// Affectation de valeur à la variable
//myDouble = 25.41;

//// Afficher la valeur de la variable
//Console.WriteLine(myDouble);
//Console.WriteLine(myDouble.GetType()); // Single

//double myDouble2 = 30.41;
//myDouble = myDouble2;
//myDouble2 = 40.41;

//Console.WriteLine(myDouble);
//Console.WriteLine(myDouble2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (Double) : ");
//myDouble = Convert.ToDouble(Console.ReadLine()); // Convertion en Double suportée par la class Convert
//Console.WriteLine(myDouble);
//Console.WriteLine(myDouble.GetType());

///*
// * LE TYPE DECIMAL => Decimal (±1.0 × 10^-28 to ±7.9228 × 10^28)
// */

//// Déclaration de la variable
//decimal myDecimal;

//// Affectation de valeur à la variable
//myDecimal = 25.41M;

//// Afficher la valeur de la variable
//Console.WriteLine(myDecimal);
//Console.WriteLine(myDecimal.GetType()); // Single

//decimal myDecimal2 = 30.41M;
//myDecimal = myDecimal2;
//myDecimal2 = 40.41M;

//Console.WriteLine(myDecimal);
//Console.WriteLine(myDecimal2);

//// Lecture de saisie utilisateur
//Console.Write("Veuillez saisir votre age (DECIMAL) : ");
//myDecimal = Convert.ToDecimal(Console.ReadLine()); // Convertion en DECIMAL suportée par la class Convert
//Console.WriteLine(myDecimal);
//Console.WriteLine(myDecimal.GetType());


#endregion

#region LES VARIABLES DE TYPE "BOOLEENNE"
// Déclaration d'une variable numérique type bool
bool myBool;

// Initialisation et affectation de valeur
myBool = true;
Console.WriteLine(myBool);
Console.WriteLine(myBool.GetType());
myBool = false;
Console.WriteLine(myBool);
Console.WriteLine(myBool.GetType());
#endregion

#region LES VARIABLES DE TYPE "OBJECT"
// Déclaration d'une variable numérique type objet
object monObjet;

// Initialisation et affectation de valeur
monObjet = "Ma chaine Objet";
Console.WriteLine(monObjet);
Console.WriteLine(monObjet.GetType());
monObjet = 35;
Console.WriteLine(monObjet);
Console.WriteLine(monObjet.GetType());
monObjet = true;
// Affichage
Console.WriteLine(monObjet);
Console.WriteLine(monObjet.GetType());
#endregion



Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();