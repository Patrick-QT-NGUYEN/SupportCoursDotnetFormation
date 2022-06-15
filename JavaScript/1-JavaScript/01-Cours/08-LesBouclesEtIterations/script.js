/**
 * Les Boucles et itérations
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

/**
 *  BOUCLE TANT QUE => while
 */

// Exemple de boucle while
var i = 1;
while (i <= 10) {
    console.log(`La boucle while s'est executée ${i} fois.`);
    i++; // Attention aux boucles infinies
}
console.log("A la sortie de la boucle While, i vaut : " + i);//11


/**
 * BOUCLE FAIRE TANT QUE => Do...While
 */
do {
    console.log(`La boucle Do...while s'est executée ${i} fois.`);
    i++;
} while (i <= 10)

console.log("A la sortie de la boucle Do...While, i vaut : " + i);


/**
 * BOUCLE POUR => For(var itération ; condition de sortie ; incrémentation )
 */

// Configuration d'une boucle j
for (let j = 1 ; j <=10 ; j++ ){
    console.log(`La boucle for s'est executée ${j} fois.`);
}

// console.log(j); // Leve une exeption car la variable et detruite par le garbage collector

/**
 * EXERCICE
 * A partir du tableau numérique suivant :
 * 
 * let names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];
 * 
 * 1/ Gràce à une boucle for, afficher la liste des prenoms du tableau
 * 2/ Gràce à une boucle while, afficher la liste des prenoms du tableau
 */
 let names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];


console.log("Itération avec la boucle For du tableau names :");
// 1 - Boucle For
for(let j = 0 ; j < names.length ; j++){
    console.log(names[j]);
}

console.log("Itération avec la boucle while du tableau names :");
// 2 - Boucle while
let j = 0;
while(j < names.length){
    console.log(names[j]);
    j++; // attention aux boucles infinies
}

/**
 * BOUCLES POUR...dans : For... in
 */

// Parfait pour les tableaux associatif
let contact ={
    nom:"Richard",
    prenom :"Pierre",
    telephone : "0123456789",
    email : "prichard@gmail.com"
}

// Exemple de boucle For...in sur contact
for(let toto in contact){
    // console.log(toto); // Permet d'afficher les clé
    // console.log(contact[toto]); // permet d'afficher les valeur pour chaque clé
    console.log(toto + " : " + contact[toto]);
}

/**
 * BOUCLE FOR OF
 */
// Utilisation du tableau numérique names de l'exercice précedent

// Itération du tableau avec une boucle for "classique"
for(let j = 0 ; j < names.length ; j = j+2){
    console.log(names[j]);
}

// Exemple de boucle For...of
for(const name of names){ // Utiliser let ou const => var is deprecated
    console.log(`Avec la boucle for...of, names contient ${name}`);
}

/**
 * INSTRUCTION BREAK;
 */
 let z;
for( z = 1 ; z <= 100 ; z++){
    console.log(z);
    if(z === 50){
        break;
    }
}
console.log(z);


/**
 * INSTRUCTION CONTINUE;
 */

for( z = 1 ; z <= 100 ; z++){ 
    
    // Instruction sont executée
    if(z === 50){
        continue;
    }
    // A la valeur de z = 50 ces instruction sont ignorée
    console.log(z);
}




















