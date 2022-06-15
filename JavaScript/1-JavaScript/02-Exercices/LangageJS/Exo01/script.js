/**
 * EXERCICE 01 - Les Variables - Les variables type chaîne de caractères
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var prenom = "",
    nom ="",
    resultat="",
    affichage ="";

// Affichage du titre dans le HTML
affichage += "<h3>Addition de deux variables de type chaîne (Concaténation)</h3>";

// Récupération des aisies utilisateur pour le nom et prénom
nom = prompt("Veuillez saisir votre nom : ");
affichage += `<span>Vous avez saisi <b>${nom}</b></span><br/>`;
prenom = prompt("Veuillez saisir votre prénom : ");
affichage += `<span>Vous avez saisi <b>${prenom}</b></span><br/>`;


// Addition des deux chaînes (concaténation)
// affichage += "Bonjour " + prenom + " " + nom;
resultat = "Bonjour <b>" + prenom + " " + nom +"</b> <br/>";

// Ajout de résultat à la variable affichage
affichage += resultat;

// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


