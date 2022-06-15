// Commentaire sur une seule ligne

/*
    Commentaire Multilignes
*/

/**
 *  Commentaire multilignes
 */

/**
 *  LES VARIABLES
 */

// Déclaration d'une variable ne JS (ES5)
var prenom;

// Affichage de la valeur de prenom dans la console
console.log(prenom);

// Affichage du type de la variable dans la console
console.log(typeof(prenom));

// Affectaction de valeur à la variable prenom
prenom = "Anthony";

// Affichage de la valeur de prenom dans la console
console.log(prenom);

// Affichage du type de la variable dans la console
console.log(typeof(prenom));

// console.clear();

// Déclaration et Affectaction de valeur à la variable nom
var nom = "Di Persio";

// Affichage de la valeur de nom dans la console
console.log(nom);

// Affichage du type de la variable dans la console
console.log(typeof(nom));

// Déclaration d'une varaible Age et affectaction de valeur
var age = 20;

// Affichage de la valeur de nom dans la console
console.log(age);

// Affichage du type de la variable dans la console
console.log(typeof(age));

// Concaténation des trois variables nom, prenom et age
console.log("Je m'appelle " + nom + " " + prenom + " et j'ai "+ age + " ans.");
console.log(`



Affichage console


multilignes
`)


console.log(`Je m'appelle ${nom} ${prenom} et j'ai ${age} ans.`)




// Récupération de valeur issues de saisies utilisateur
// nom = prompt("Veuillez saisir votre nom : ");
// prenom = prompt("Veuillez saisir votre prénom : ");
// age = Number(prompt("Veuillez saisir votre age : "));

// Concaténation des trois variables nom, prenom et age
console.log("Je m'appelle " + nom + " " + prenom + " et j'ai "+ age + " ans.");

// Affichage du type de la variable dans la console
console.log(age+1);

// Type big int (pour les grand nombre)
var bigNumber = 8198552921648690045555555n;
console.log(typeof(bigNumber));

// type booléenne 
var myBool = true;
console.log(typeof(myBool));