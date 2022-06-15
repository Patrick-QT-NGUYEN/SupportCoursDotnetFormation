/**
 * EXERCICE 11 - LES STRUCTURES CONDITIONNELLES - If...Else... Consonne / Voyelle
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaraton d'un tableau de voyelles
const voyelle = ["A","E","I","O","U","Y"];

// Affichage du titre dans le HTML
var affichage = `<br/><h3>If..Else...Consonne / Voyelle</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
var lettre = prompt("Veuillez une lettre : ").toUpperCase();

// // Mise en place d'une structure conditionnelle pour vérifier si la lettre est une voyelle
// if (lettre === "A" ||
//     lettre === "E" ||
//     lettre === "I" ||
//     lettre === "O" ||
//     lettre === "U" ||
//     lettre === "Y" )    
//         affichage += `La lettre ${lettre} est une voyelle`;    
//     else
//         affichage += `La lettre ${lettre} est une consonne`;

// Vérifier si la lettre saisie par l'utilisateur appartient au tableau de voyelles
if (voyelle.includes(lettre))    
        affichage += `La lettre ${lettre} est une voyelle`;    
    else
        affichage += `La lettre ${lettre} est une consonne`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


