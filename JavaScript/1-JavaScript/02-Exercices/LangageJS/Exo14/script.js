/**
 * EXERCICE 14 - LES STRUCTURES CONDITIONNELLES - If...Else... Quel est la nature du triangle ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var AB = 0,
    BC = 0,
    CA = 0,
    affichage ="";

// Affichage du titre dans le HTML
affichage = `<br/><h3>Quelle est la nature du triangle...?</h3>`;


// Récupération des saisies utilisateur pour les coté du triangle
AB = Number(prompt("Veuillez saisir la longeur du segment [AB] : "));
BC = Number(prompt("Veuillez saisir la longeur du segment [BC] : "));
CA = Number(prompt("Veuillez saisir la longeur du segment [CA] : "));


// Mise en place d'une structure conditionnelle pour vérifier la nature du triangle
if (AB === BC && BC === CA)
    affichage += `Le triangle ABC est équilatéral`;
else if (AB === BC)
    affichage += `Le triangle est isocèle en B mais n'est pas équilatéral`;
else if (BC === CA)
    affichage += `Le triangle est isocèle en C mais n'est pas équilatéral`;
else if (AB === CA)
    affichage += `Le triangle est isocèle en A mais n'est pas équilatéral`;
else
    affichage += `Le triangle n'est isocèle ni en A, ni en B, ni en C.`;



// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


