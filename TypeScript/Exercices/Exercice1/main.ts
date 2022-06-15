/**
 * EXERCICE - Accroissement Population
 */

// Déclaration variables
let nbhabitant: number = 96809,
    date: number = 2015,
    nbAnnee: number = 0,
    taux: number = 0.89;

console.log(`Accroissement de la population de Tourcoing\n
En ${date}, il a été recensé ${nbhabitant} habitants.
Le taux d'accroissement de la population étant de ${taux}%.\n
Combiens faudra-t-il d'années pour atteindre une population de 120.000 habitants ?\n`);

// Boucle while
while (nbhabitant < 120000) {

    nbhabitant += nbhabitant * (taux / 100);
    console.log(`\tEn ${++date}, il y aura ${Math.round(nbhabitant)} habitants`);
    nbAnnee++;
}
console.log(`\nAvec un taux d'accroissement de la population de ${taux}%, en ${date},
il y aura ${Math.round(nbhabitant)} habitants dans la ville de Tourcoing.
Il aura fallu ${nbAnnee} années.`);