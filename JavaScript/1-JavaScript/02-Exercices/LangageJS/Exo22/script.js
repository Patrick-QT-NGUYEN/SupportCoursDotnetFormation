/**
 * EXERCICE 22 - LES STRUCTURES ITERATIVES - FOR - Menu...Sous-Menu
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
let Affichage = "<br><h2>Menu et sous-menu</h2>";

for (let i = 1; i < 4; i++) {
    Affichage += `<div class="tab-1">Chapitre <b>${i}</b>`;
    for (let j = 1; j < 4; j++) {
        Affichage += `<div class="tab-5">-Partie <b>${i}.${j}</b></div>`;
    }
    Affichage += "</div>";
}

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

