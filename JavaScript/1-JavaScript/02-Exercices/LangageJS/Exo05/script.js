/**
 * EXERCICE 05 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Le traitement des chaînes
 */

// ChaineATraiter = "sALut cOMmeNT çA vA?";


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var chaine = "",
    chaineMEF = "",
    affichage = "" ;

// Affichage du titre dans le HTML
affichage += `<br/><h3>Traitement d'une chaîne de caractères</h3>`;

// Récupération des saisies utilisateur pour la chaine
chaine = prompt("Veuillez saisir une chaine à traiter : ");

// Affichage de la saisie utilisateur
affichage += `<br/><div>Vous avez saisi : <b>${chaine}</b></div><br/>`;

// Mise en miniscule de la chaine et affichage
affichage += `<br/><div>La chaîne en minuscule : <b>${chaine.toLowerCase()}</b></div><br/>`;

// Afficher la chaine mise en tableau
affichage += `<div>Mise en tableau : <b>${chaine.toLowerCase().split('')}</b></div><br/>`;

// Traitement de la chaine avec mise en majuscule des premieres lettre ce chaque mot
chaineMEF = chaine.toLowerCase().split(/[\s,']/).map(mot => mot[0].toUpperCase()+mot.slice(1)).join(' ');
/*
    "sALut cOMmeNT çA vA?"
    "salut comment ça va?"
    "s,a,l,u,t, ,c,o,m,m,e,n,t, ,c,a, ,v,a,?"
    "salut,comment,ca,va?" 
    "Salut,Comment,Ca,Va?"
    "Salut Comment Ca Va?"
*/
affichage += `<div>La chaîne après traitement : <b>${chaineMEF}</b></div><br/>`;




// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


