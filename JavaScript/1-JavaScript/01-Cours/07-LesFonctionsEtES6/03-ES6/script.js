/**
 * Les nouveautés ES6 (Implémentation de la spécification ECMA6)
 */
// Récupération de l'element du DOM #App
const app = document.querySelector('#app');

console.log("---------- Nouveauté ES6 ----------");

/**
 *  Let
 * 
 *  Jusqu'a présent nous utilision var pour la déclaration de nos variables
 *  Maintenant nous utiliserons let, voyons pourquoi =>
 */
console.log("---------- Mot clé let => remplace var ----------");

// Afficher une variable avant la déclaration
console.log(prenomVar); // Hoisting (remontée de la déclaration variable) => Pour le navigateur la variable existe, seule sa valeur est non initialisé
//console.log(nomLet); // Provoque une erreur de variable non déclarée
// Déclaration des variables (var et let)
var prenomVar = "Richard";
let nomLet = "Gear";

/**
 * Const
 * 
 * Pour déclarer une constante
 * 
 */

const nbMax = 128;
console.log("NbMax vaut : " + nbMax / 2);
// nbMax = 129; // Uncaught TypeError: Assignment to constant variable.
// console.log(nbMax);

const fruits = ["Pomme"];
//fruits = ["Abricots","Poire"]; // Uncaught TypeError: Assignment to constant variable.

fruits.push("Abricots", "Poire"); // Ici const garantit la structure de l'objet (tableau numérique de string)
console.table(fruits);


/**
 * Les nouvelles méthodes apportées à la classe Array
 * 
 *  .foreach()
 *  .map()
 *  .find()
 *  .filter()
 * 
 */
console.log("---------- Les nouvelles Méthodes ES6 ----------");

// Déclaration d'un tableau de légumes (2 dimensions)

const vegetables = [
    {
        code: 1,
        name: "Carotte",
        price: 1.99
    },
    {
        code: 2,
        name: "Poivron Vert",
        price: 4.99
    },
    {
        code: 3,
        name: "Poivron Rouge",
        price: 4.99
    },
    {
        code: 4,
        name: "Haricot Vert",
        price: 3.89
    },
    {
        code: 5,
        name: "Courgette",
        price: 2.59
    },
];

// Affichage du tableau dans la console
console.table(vegetables);

/**
 *  .foreach()
 */

console.log("\n------ Parcours du tableau Vegetables avec .foreach(vegetable) --------");

// Affichage du tableau avec un foreach
vegetables.forEach(function (vegetable) {
    console.log(vegetable.name);
    app.innerHTML += `<h3>${vegetable.name}</h3>`;
});
console.log("\n------ Parcours du tableau Vegetables avec .foreach avec index --------");

// Affichage du tableau avec les index
vegetables.forEach(function (vegetable, index) {
    console.log((index + 1) + " - " + vegetable.name);
    app.innerHTML += `<h3>${index + 1} - ${vegetable.name}</h3>`;
});


/**
 *   .map()
 */
console.log("\n------ Parcours du tableau Vegetables avec .map(function(){}) ------");

const vegetablesNames = vegetables.map(function (vegetable) {
    return vegetable.name;
})

console.table(vegetables);
console.table(vegetablesNames); // map() nous retourne un nouveau tableau indexé



/**
 *  Find() => retourne le premier element correspondant aux critères
 */
console.log("\n------ Parcours du tableau Vegetables avec .find(function(){}) ------");

const poivron = vegetables.find(function (vegetable) {
    return vegetable.name.includes("Poivron");
})

console.log(poivron);


/**
 *  Filter() => retourne un tableau contenant n occurences correspondant à nos critères
 */
console.log("\n------ Parcours du tableau Vegetables avec .filter(function(){}) ------");

const poivrons = vegetables.filter(function (vegetable) {
    return vegetable.name.includes("Poivron");
})

console.log(poivrons); // Filter() nous retourne un nouveau tableau indexé

/**
 * Les litéraux de gabarit
 * 
 * Nouvelle possibilité de concaténer les variables dans les
 * chaines de caractère à l'aide du nouveau caractère de templating " ` " => backtic (accent grave)
 */
console.log("\n---------- Les litéraux de gabarit ----------");

let prenom = "jean";
let nom = "valjean";

console.log("Bonjour " + prenom + " " + nom);
console.log(`Bonjour ${prenom} ${nom}, tu vas bien?`);

/**
 * DESTRUCTURING 
 * 
 * Accès simplifié aux élément d'un tableau... d'un objet.
 */

console.log("\n----------- Destructuring ----------");

// AVEC DES TABLEAUX
const tabNum = [1, 2, 3, 4, 5];
console.table(tabNum);

// // EN ES5
// const a = tabNum[0];
// const b = tabNum[1];

// En ES6 avec le destructuring
const [a, b] = tabNum

// Affichage dans la console
console.log(a);
console.log(b);

// AVEC UN TABLEAU ASSOCIATIF (Objet)
const user = {
    firstname: "Anthony",
    lastname: "Di Persio",
    age: 35,
    active: false
}

// // EN ES5 
// const firstname = user.firstname;
// const lastname = user.lastname;


// EN ES6 avec le Destructuring
const { firstname, lastname } = user;


console.log(`Avec le destructuring de l'objet user : ${firstname} ${lastname}`);


// AVEC DES FONCTIONS

// Sans DESTRUCTURING
function getFullName(user) {
    return `${user.firstname} ${user.lastname}`;
}

console.log("Sans destructuring de méthode getFullName() : " + getFullName(user));

// AVEC DESTRUCTURING
function getFullName({ firstname, lastname }) {
    return `${firstname} ${lastname}`;
}

console.log("Avec destructuring de méthode getFullName() : " + getFullName(user));

/**
 * REST OPERATOR => ...
 */
console.log("\n----------- REST OPERATOR ----------");
let haricot = { ...vegetables[3] }; // Récupération de l'ensemble des clé / valeur à l'index indiqué

console.table(vegetables);
console.log(vegetables[3]);
console.log(haricot);


// Modifier la valeur du prix des haricots
haricot.price = haricot.price * 1.20;


console.table(vegetables);
console.log(vegetables[3]);
console.log(haricot);

// Autre exemple avec notre tableau numérique TabNum
console.table(tabNum);

// // EN ES5
// const a = tabNum[0];
// const b = tabNum[1];

// En ES6 avec les destructurin nous pouvons l'ecrire
const [c, d, ...e] = tabNum;

console.log(c);
console.log(d);
console.table(e);

/**
 * LES FONCTIONS FLECHEES => ArrowFunction()
 * 
 * Pour écrire une fonction flechées, nous allons utiliser un opérateur nomé 
 *              fat Arrow   =>
 */

// Cas 1
// SANS PARAMS
let test = function () {
    return "Toto";
}

// Equivalent au cas 1
test = () => {
    return "Toto";
}

// Simplification seulement si la fonction ne fait qu'un return
test = () => "Toto";

console.log(test);


// Cas 2
// AVEC PARAMS
let test2 = function (vegetable) {
    return vegetable.name;
}

// Equivalent à
test2 = (vegetable) => {
    return vegetable.name
}

// Simplification seulement si la fonction ne fait qu'un return
test2 = (vegetable) => vegetable.name;


console.log(test2);


// Cas 3
// Avec au moins deux params
let test3 = function (firstname, lastname) {
    return `${firstname} , ${lastname}`;
}

// Equivalent à 
test3 = (firstname, lastname) => {
    return `${firstname} , ${lastname}`
}

// Simplification seulement si la fonction ne fait qu'un return
test3 = (firstname, lastname) => `${firstname} ${lastname}`;

console.log(test3);

/**
 * Valeur des paramètres par défaut d'une fonction()
 */

function AireCarre(nb = 3) {
    return nb * nb;
}

console.log(AireCarre(5)); // 25
console.log("Default params : " + AireCarre()); // 9

/**
 * LES CLASSES => L'ES6 a intruduit les classe et donc le paradigme Orienté Objet 
 */

class Personne {

    // C'est la moule qui définit les caractéristiques de nos objet
    constructor(Params1 = "George", Params2 = "Clinton") {
        this.firstname = Params1;
        this.lastname = Params2;
    }

    getFullName() {
        return this.firstname + " " + this.lastname;
    }
}

let personne1 = new Personne("Bootsy", "Colins");
let personne2 = new Personne();
console.log(personne2.firstname);
console.log(personne1.firstname);

// Deux maniere d'acceder aux méthode d'un classe
// 1- Par une instance de classe
//Personne.getFullName();

// 2- Par une instance objet => new Personne(params1, params2)
console.log(personne1.getFullName());
console.log(personne2.getFullName());

/**
 * L'HERITAGE EN JAVASCRIPT
 * 
 * Comment faire? Avec le mot clé extends suivi du nom de la classe de laquelle on souhaite hériter
 * 
 */

class Cadre extends Personne {
    // Ajouter le constructeur pour nos cadre
    constructor(Params1, Params2, ParamsJob = "Cadre") {
        super(Params1, Params2);
        this.job = ParamsJob;
    }

    getJob() {
        return this.job;
    }

    display() {
        return `${super.getFullName()} - ${this.job}`;
    }
}

let cadre1 = new Cadre("Jacques", "Chirac", "CEO");
let cadre3 = new Cadre("Jacques", "Chirac", "CEO");
let cadre2 = new Cadre("François", "Mitterand");
cadre3.firstname = "Bernadette";

console.log(cadre1);
console.log(cadre2);
console.log(cadre3);
console.log(cadre1.getJob());
console.log(cadre1.display());
console.log(cadre2.getJob());
console.log(cadre2.display());