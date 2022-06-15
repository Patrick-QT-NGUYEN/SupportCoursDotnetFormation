/**
 * EXERCICE 04 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Les palindromes
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var mot = "",
    reverse = "",
    affichage = "";

// Affichage du titre dans le HTML
affichage += `<br/><h3>Ce mot est-il un palindrome?</h3>`;

// Récupération des saisies utilisateur pour le mot
mot = prompt("Veuillez saisir un mot : ").toLowerCase();
affichage += `<br/><div>Vous avez saisi : <b>${mot}</b></div><br/>`;

// Inverser le mot
reverse = mot.split('').reverse().join('');
// console.log(reverse); // vérification



// Afficher le mot inversé
affichage += `<div>Le mot inversé : <b>${reverse}</b></div><br/>`;


// Comparer le mot avec le mot inversé et affichage du résultat
if(mot===reverse){
    affichage+=`<div>Le mot <b>${mot}</b> est un palindrome</div><br/>`;
}else{
    affichage+=`<div>Le mot <b>${mot}</b> n'est pas un palindrome</div><br/>`;
}




// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


