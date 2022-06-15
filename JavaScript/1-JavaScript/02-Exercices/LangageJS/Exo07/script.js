/**
 * EXERCICE 07 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Calcul de la longeur de l'hypoténuse
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var cote1 = 0,
    cote2 = 0,
    sommeCarre = 0,
    hypotenuse = 0,
    affichage = "";

// Affichage du titre dans le HTML
affichage += `<br/><h3>Calcul de la longeur de l'ypoténuse d'un triangle rectangle</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
cote1 = Number(prompt("Veuillez saisir la longeur du premier coté : "));
cote2 = Number(prompt("Veuillez saisir la longeur du deuxieme coté : "));

// Calcul de la longeur de l'hypoténuse (Math.pow())
sommeCarre = Math.pow(cote1,2) + Math.pow(cote2,2)

// Calcul de la longeur de l'hypothénuse
//hypotenuse = Math.round(Math.sqrt(sommeCarre+Number.EPSILON)*100)/100;
hypotenuse =  Math.hypot(cote1,cote2).toFixed(2);

// Affichage des résultat dans le HTML
affichage += `<div>Les longeurs des cotés adjacents à l'angle droit étant de <b>${cote1}cm</b> et <b>${cote2}cm</b></div>
<ul>
    <li>La longeur de l'hypothénuse est de <b>${hypotenuse}cm</b></li>
</ul>
`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


