/**
 * EXERCICE 20 - LES STRUCTURES CONDITIONNELLES - SWITCH - Quel sera le montant de mes impôts ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
let Affichage = "<h4>Compter jusqu’à 10</h4><br><ul>",
    i;

for(i = 1 ; i<= 10; i++){
    Affichage += `<li>${i}</li>`;
}

Affichage += `</ul> <br> <p><b>Super je sais compte jusqu'à ${i-1}!</b></p>`









// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

