/**
 * EXERCICE 03 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - L'objet Math en Javascipt
 */

// import * as MT from 'Math' ;
// import {PI, pow, round} from 'Math' ;

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des Constantes
const pi = Math.PI;

// Déclaration des variables
var diametre = 0,
    perimetre = 0,
    aire = 0,
    affichage = "";

// Affichage du titre dans le HTML
affichage += `<h3>Utilisation des Fonctions() de l'objet Math</h3> <br/>
<h4>Utilisation de la constante &#960; (pi)</h4>  
<div>La valeur de <b> &#960;</b> est :<b> ${pi}</b></div> <br/>
`;

// Redaction de l'affichage
affichage += `<h5>Calcul du périmètre <i>(d x &#960;)</i> et de l'aire <i>(&#960; * r²)</i> d'un cercle </h4>`;

// Récupération des saisies utilisateur pour les deux nombres
diametre = Number(prompt("Veuillez saisir les diamètre du cercle : "));
affichage += `<div>Diamètre =  <b>${diametre}cm</b></div>`;

// Calcul du périmetre
perimetre = diametre * pi;

// Calcul de l'aire du cercle
aire = pi * Math.pow(diametre/2, 2 );

// Afficher les résultats
affichage += `<div>Périmètre =  <b>${perimetre}cm</b></div>
<div>Aire =  <b>${aire}cm²</b></div>
<div>Périmètre(arrondi) =  <b>${Math.round(perimetre)}cm</b></div>
<div>Aire(arrondi) =  <b>${Math.round(aire)}cm²</b></div>`;



// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


