"use strict";
/**
 * TRAVAUX PRATIQUE POO - HERITAGE - Class Véhicule
 */
exports.__esModule = true;
//import class
var Voiture_js_1 = require("./modules/Voiture.js");
var Moto_js_1 = require("./modules/Moto.js");
// Affichage du titre
console.log("\nExercice n°2 - Héritage Véhicule.\n");
// Instance de Voiture
var voiture = new Voiture_js_1["default"]("Renault", "Kangoo", 240000, 2003, "Climatisée");
// Instance de Moto
var moto = new Moto_js_1["default"]("BMW", "R1150R Rockster", 65000, 2005);
// Affichage Résultat
console.log(voiture.display());
console.log(moto.display());
