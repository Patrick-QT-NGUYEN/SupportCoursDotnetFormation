/**
 * Les Classes en JS (POO)
 */
//console.log("Je suis dans un module JS");

// Import du type Etre vivant
import EtreVivant from './js/EtreVivant.js';
// Import des classes
import Mammifere from './js/Mammifere.js';
import Vegetaux from './js/Vegetaux.js';
import Chien from './js/Chien.js';
import Fleur from './js/Fleur.js';

// instanciation d'un objet EtreVivant
let etreVivant1 = new EtreVivant("Prenom1", "nom1");
console.log(etreVivant1); 
// Execution des méthode de l'objet EtreVivant
etreVivant1.Naissance();
etreVivant1.Mort();
etreVivant1.Alimentation();
etreVivant1.Respiration();

console.log("------------ Type Mammifere ----------");
// Instanciation d'objet Mammifere et vagataux
let mammifere1 = new Mammifere("Mammifere1","typeMamifere")

// Execution des méthode de l'objet EtreVivant
//mammifere1.Naissance();
mammifere1.Mort();
mammifere1.Alimentation();
mammifere1.Respiration();

console.log("------------ Type Vegetaux ----------");
// Instanciation d'objet Mammifere et vagataux
let Vegetal1 = new Vegetaux("Vegetal1","typeVegetal")

// Execution des méthode de l'objet EtreVivant
//Vegetal1.Naissance();
Vegetal1.Mort();
Vegetal1.Alimentation();
Vegetal1.Respiration();


console.log("------------ Type Chien ----------");
// Instanciation d'objet Chien
let Medor = new Chien("médor","Berger Allemand");


// Execution des méthode de l'objet EtreVivant
Medor.Aboyer();
Medor.Alimentation();
Medor.Respiration();
Medor.Mort();

console.log("------------ Type Fleur ----------");
// Instanciation d'objet Fleur
let Cosmos = new Fleur("Cosmos","Cosmos Sulphuréus");


// Execution des méthode de l'objet EtreVivant
Cosmos.Alimentation();
Cosmos.Respiration();
Cosmos.Mort();


console.log("------------ Console.log apres Deux extends ----------");
console.log(Medor);
console.log(Cosmos);

console.log("------------ Création d'une collection de type EtreVivant ----------");

let etresVivants = [etreVivant1,mammifere1,Vegetal1,Medor,Cosmos];

for( let etre of etresVivants){
    console.log(`---------- ${etre.nom} ----------`);
    etre.Naissance();
    etre.Alimentation();
    etre.Respiration();
    etre.Mort();
    // setre.Aboyer();
    console.log(`---------------------------------\n`);    
}

Medor.Aboyer();

