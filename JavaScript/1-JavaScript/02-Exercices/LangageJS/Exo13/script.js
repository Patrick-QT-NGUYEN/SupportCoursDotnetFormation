/**
 * EXERCICE 13 - LES STRUCTURES CONDITIONNELLES - If...Else... Quelle catégorie pour mon enfant...?
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Affichage du titre dans le HTML
var affichage = `<br/><h3>Quelle catégorie pour mon enfant...?</h3>`;
var age = 0;

// Récupération des saisies utilisateur pour le coté du carré
age = Number(prompt("Veuillez saisir l'age de votre enfant : "));


// Mise en place d'une structure conditionnelle pour vérifier l'age correcpond à une catégorie
if (age < 3)
    affichage += `Votre enfant est trop jeune pour pratiquer`;
else if (age >= 3 && age <= 6)
    affichage += `Votre enfant est dans la catégorie "Baby"`;
else if (age >= 7 && age <= 8)
    affichage += `Votre enfant est dans la catégorie "Poussin"`;
else if (age >= 9 && age <= 10)
    affichage += `Votre enfant est dans la catégorie "Pupille"`;
else if (age == 11 || age == 12)
    affichage += `Votre enfant est dans la catégorie "Minime"`;
else if (age >= 13 && age < 18)
    affichage += `Votre enfant est dans la catégorie "Cadet"`;
else
    affichage += `Mais ce n'est plus un enfant !`;



// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


