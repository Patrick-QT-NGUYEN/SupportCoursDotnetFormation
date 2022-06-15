/**
 * TRAVAUX PRATIQUE POO - HERITAGE - Class Véhicule
 */

//import class
import Voiture from "./modules/Voiture.js";
import Moto from "./modules/Moto.js";

// Affichage du titre
console.log("\nExercice n°2 - Héritage Véhicule.\n");

// Instance de Voiture
let voiture = new Voiture("Renault","Kangoo",240000,2003,"Climatisée");

// Instance de Moto
let moto = new Moto("BMW","R1150R Rockster",65000,2005);

// Affichage Résultat

console.log(voiture.display());
console.log(moto.display());
