/**
 * EXERCICE 09 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Calcul des intérêts
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var capitalInitial = 0,
    taux = 0,
    duree,
    capitalFinal = 0,
    interets = 0,
    affichage = "";

// Affichage du titre dans le HTML
affichage += `<br/><h3>Calcul du montant des intérêts sur la durée</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
capitalInitial = Number(prompt("Veuillez saisir le montant du capital initial (en €) : "));
taux = Number(prompt("Veuillez saisir le taux d'intérêts de l'épargne ( en % ) : "));
duree = Number(prompt("Veuillez saisir le nombre d'année de l'épargne (en année(s)) : "));

// Calcul des intérets
capitalFinal = Math.round(capitalInitial * Math.pow(1+(taux/100),duree));
interets = Math.round(capitalFinal - capitalInitial);

// Affichage des résultat dans le HTML
affichage += `<div>Avec un capital initial de <b>${capitalInitial}€</b>,placé à <b>${taux}%</b>, sur une durée de <b>${duree} année(s)</b></div>
<ul>
    <li>Le montant des intérêts s'éléve à <b>${interets}€</b></li>
    <li>Le capital final à l'issue sera de <b>${capitalFinal}€</b></li>
</ul>
`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


