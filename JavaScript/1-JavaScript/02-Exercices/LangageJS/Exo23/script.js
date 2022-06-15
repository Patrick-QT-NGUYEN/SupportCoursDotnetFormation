/**
 * EXERCICE 23 - LES STRUCTURES ITERATIVES - FOR - Tables de Multiplications
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
let Affichage = "<br><h2>Tables de Multiplications de 1 à 10</h2>";

for (let i = 1; i < 11; i++) {
    Affichage += `<div class="card"><h5>Table de <b>${i} :</b></h5><ul>`;
    for (let j = 1; j < 11; j++) {
        Affichage += `<li class="tab-5">${i} x ${j} = <b>${i*j}</b></li>`;
    }
    Affichage += "</ul></div>";
}

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

