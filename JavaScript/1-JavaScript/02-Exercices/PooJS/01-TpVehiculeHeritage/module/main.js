import Vehicule from "./js/Vehicule.js";
import Voiture from "./js/Voiture.js";
import Moto from "./js/Moto.js";

const result = document.querySelector('#result');

// // Instance de la Class Véhicule
// let vehicule = new Vehicule("Renault", "Kangoo", 240000, 2003);

// console.log(vehicule.Display());
// result.textContent = vehicule.Display();

// Instance de la class Voiture
let voiture = new Voiture("Renault", "Kangoo", 240000, 2003, true);
console.log(voiture.Display());
result.innerHTML += `<div>${voiture.Display()}</div>`;

// Instance de la class Moto
let moto = new Moto("BMW", "R1150R Rockster", 65000, 2005);
console.log(moto.Display());
result.innerHTML += `<div>${moto.Display()}</div>`;
