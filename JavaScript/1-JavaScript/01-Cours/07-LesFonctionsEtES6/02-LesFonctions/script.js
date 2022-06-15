/**
 * LES FONCTIONS EN JS
 */

const result = document.querySelector('#result');

// // FONCTIONS NATIVES
// // Afficher une alert à l'utilisateur (alert())
//     alert("Coucou toi!");

// //Demander une saisie à l'utilisateur (prompt())
// var firstname = prompt("Quel est votre prénom ?");

// console.log(`Votre prénom est ${firstname}.`); // Affichage du prénom saisi


/**
 * LES FONCTIONS NON NATIVES (USER)
 */

/**
 * Fonction sans paramètre
 */
function hello(){
    // Lors de l'appel à cette fonction, les instruction ci -dessous seront executées
    alert("Hello world!");
}

// Appel à la fonction hello()
//hello();

/**
 *  Fonction avec paramètres
 */
function helloParams(firstname){
    alert(`Hello ${firstname}`);    
}

// Appel à la fonction hello()
//helloParams("Anthony");
//let firstname = prompt("Veuillez saisir un prénom")
//helloParams(firstname);

function AfficherAge(age){
   console.log(`j'ai ${age} ans`);    
   console.log(`dans un an j'aurai ${age+1} ans`);    
}
//let age = Number(prompt("Veuillez saisir votre age "));
//let maVar = AfficherAge(age);
//console.log(maVar);

/**
 *  Fonction avec retour
 */

function helloReturn(firstname){
    // Création de variable locale à la fonction
    let helloDisplay = `Hello ${firstname}`;
    return helloDisplay;
}
// Log de la variable HelloDisplay leve un exception : Uncaught ReferenceError: helloDisplay is not defined
//console.log(helloDisplay);

// Appel de fonction avec retour
console.log(helloReturn("Anthony"));
let chaine = helloReturn(prompt("Veuillez saisir un prenom : "));
//let chaine = "Hello toi!";
console.log(chaine);

function Display(toto){
    result.innerHTML+= `<div>${toto}</div>`;
}

Display(chaine);
chaine = helloReturn(prompt("Veuillez saisir un prenom : "));
Display(chaine);