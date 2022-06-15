/**
 * EXERCICE 24 - LES STRUCTURES ITERATIVES - FOR - Accroissement Population
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variable
let nbHabitant = 96809,
    date = 2015,
    nbAnnee = 0,
    taux = 0.89,
    Affichage="";


// Déclaration des variables
Affichage += `<h2>Accroissement de la population</h2>
                <p>En <b>2015</b>, il a été recencé <b>${nbHabitant} habitants</b>.Le taux d'accroissement de la populationétant de <b>${taux}%</b>. Combiens faudra-t-il d'années pour atteindre une population de <b>120.000 habitants</b>.</p> <hr>`;

for (let i = 1; i <= 100; i++) {
    nbHabitant += nbHabitant * (taux/100);
    nbAnnee++;
    date++;
    Affichage +=`En ${date}, il y aura <b>${nbHabitant} habitants</b>.<br/><hr>`;
    if(nbHabitant >= 120000)
        break;
}

Affichage += `<p>Avec un taux d'accroissement de la population de <b>${taux}%</b>,en <b>${date}</b>, il y aura <b>${Math.round(nbHabitant)} habitants</b> dans la ville de <b>Tourcoing</b>. Il aura fallu <b>${nbAnnee} année(s)</b>.</p>`

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

