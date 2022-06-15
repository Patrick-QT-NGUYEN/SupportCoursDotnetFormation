/**
 * EXERCICE 06 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Calcul du périmètre et de l'aire d'un carré / rectangle
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var cote = 0,
    longeur = 0,
    largeur = 0,
    perimetreCarre = 0,
    aireCarre = 0,
    perimetreRectangle = 0,
    aireRectangle = 0,
    affichage = "";

/**
 * CARRE
 */


// Affichage du titre dans le HTML
affichage += `<br/><h3>Calcul de l'aire et du périmètre d'un carré</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
cote = Number(prompt("Veuillez saisir la longeur d'un coté du carré : "));

// Calcul du périmetre du carré
perimetreCarre = cote * 4;

// Calcul de l'aire du Carré
aireCarre = Math.pow(cote, 2);


// Affichage des résultat dans le HTML
affichage += `<div>Les longeurs des cotés étant de <b>${cote}</b>cm</div>
<ul>
    <li>Le périmètre de ce carré est de <b>${perimetreCarre}</b>cm</li>
    <li>L'aire de ce carré est de <b>${aireCarre}</b>cm<sup>2</sup></li>
</ul>
`;

/**
 * RECTANGLE
 */


// Affichage du titre dans le HTML
affichage += `<hr><br/><h3>Calcul de l'aire et du périmètre d'un rectangle</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
longeur = Number(prompt("Veuillez saisir la longeur du rectangle : "));
largeur = Number(prompt("Veuillez saisir la largeur du rectangle : "));

// Calcul du périmetre du rectangle
perimetreRectangle = (longeur + largeur) * 2;

// Calcul de l'aire du Carré
aireRectangle = longeur * largeur;


// Affichage des résultat dans le HTML
affichage += `<div>Les longeurs des cotés du rectangle étant de <b>${longeur}</b>cm pour la longeur et de <b>${largeur}</b>cm pour la largeur</div>
<ul>
    <li>Le périmètre de ce rectangle est de <b>${perimetreRectangle}</b>cm</li>
    <li>L'aire de ce rectangle est de <b>${aireRectangle}</b>cm<sup>2</sup></li>
</ul>
`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


