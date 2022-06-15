/**
 * LES OPERATEURS ARITHMETIQUES
 */

// Déclaration des variables
var nb1=10 , nb2=5, resultat;

console.log(typeof(nb1));
console.log(typeof(nb2));
console.log(typeof(resultat));

// L'addition
resultat = nb1 + nb2 ;
console.log(`L'Addition : \n${nb1} + ${nb2} = ${resultat}`);
// console.log(`${nb1} + ${nb2} = ${nb1 + nb2}`);

// La soustraction
resultat = nb1 - nb2 ;
console.log(`La soustraction : \n${nb1} - ${nb2} = ${resultat}`);

// La multiplication
resultat = nb1 * nb2 ;
console.log(`La multiplication : \n${nb1} x ${nb2} = ${resultat}`);

// La division
resultat = nb1 / nb2 ;
console.log(`La division : \n${nb1} / ${nb2} = ${resultat}`);

// Le modulo
resultat = nb1 % nb2 ;
console.log(`Le reste de : \n${nb1} modulo ${nb2} = ${resultat}`);

/**
 * LES OPERATEURS COMBINES
 */

// L'addition
nb1 = nb1 + 5;
console.log(`Nb1 vaut : ${nb1}`);
// Opérateur combiné Addition
nb1 += 5;
console.log(`Nb1 vaut : ${nb1}`);

// La soustraction
nb1 = nb1 - 5;
console.log(`Nb1 vaut : ${nb1}`);
// Opérateur combiné soustraction
nb1 -= 5;
console.log(`Nb1 vaut : ${nb1}`);

// La division
nb1 = nb1 / 5;
console.log(`Nb1 vaut : ${nb1}`);
// Opérateur combiné soustraction
nb1 /= 5;
console.log(`Nb1 vaut : ${nb1}`);

// La multiplication
nb1 = nb1 * 5;
console.log(`Nb1 vaut : ${nb1}`);
// Opérateur combiné soustraction
nb1 *= 5;
console.log(`Nb1 vaut : ${nb1}`);

// Le modulo
resultat = nb1 % 5;
console.log(`Nb1 vaut : ${resultat}`);
// Opérateur combiné soustraction
nb1 %= 5;
console.log(`Nb1 vaut : ${nb1}`);

/**
 * Les opérateurs d'incrémentation et de décrémentation
 */

// Incrémentation
console.log(`La valeur avant incrémentation : ${nb1}`);

nb1 = nb1 + 1;
console.log(`La valeur après incrémentation "classique" : ${nb1}`);

// Peux se simplifier en 
nb1 +=1;
console.log(`La valeur après incrémentation avec l'opérateur combiné (+=) : ${nb1}`);

// Avex l'opérateur d'incrémentation
nb1++;
console.log(`La valeur après incrémentation avec l'opérateur d'incrémentation (++) : ${nb1}`);

// Décrémentation
console.log(`La valeur avant décrémentation : ${nb1}`);

nb1 = nb1 - 1;
console.log(`La valeur après décrémentation "classique" : ${nb1}`);

// Peux se simplifier en 
nb1 -=1;
console.log(`La valeur après décrémentation avec l'opérateur combiné (-=) : ${nb1}`);

// Avex l'opérateur d'incrémentation
nb1--;
console.log(`La valeur après décrémentation avec l'opérateur de décrémentation (--) : ${nb1}`);


/**
 * Positionnement de l'opérateur d'incrémentation
 */

nb1=1;
console.log(nb1++); // La variable est lue avnt d'etre incrémentée
console.log(`Apres incrementations, nb1 vaut ${nb1}`);

nb1=1;
console.log(++nb1); // La variable est incrémentée avant sa lecture 
console.log(`Apres incrementations, nb1 vaut ${nb1}`);
