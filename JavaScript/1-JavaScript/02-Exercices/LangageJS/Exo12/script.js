/**
 * EXERCICE 12 - LES STRUCTURES CONDITIONNELLES - If...Else... Le nombre est-il divisible par...?
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Affichage du titre dans le HTML
var affichage = `<br/><h3>Le nombre est-il divisible par...?</h3>`;
var nb1 = 0, nb2 = 0;
console.log(typeof (nb1));
// Récupération des saisies utilisateur pour le coté du carré
nb1 = Number(prompt("Veuillez un chiffre / nombre : "));
nb2 = Number(prompt("Veuillez un chiffre / nombre diviseur : "));

console.log(typeof (nb1));
// Mise en place d'une structure conditionnelle pour vérifier si la nb1 est divisible par nb2  
if (nb1 % nb2 == 0)
    affichage += `le nombre <b>${nb1}</b> est divisible par <b>${nb2}</b>`;
else
    affichage += `le nombre <b>${nb1}</b> n'est pas divisible par <b>${nb2}</b>`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


