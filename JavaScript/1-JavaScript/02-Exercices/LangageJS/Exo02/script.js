/**
 * EXERCICE 02 - Les Variables et opérateurs - Les variables numériques
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var nb1 = 0,
    nb2 = 0,
    resultat = 0,
    affichage = "";

// Affichage du titre dans le HTML
affichage += "<h3>Addition de deux variables numérique</h3>";

// Récupération des saisies utilisateur pour les deux nombres
nb1 = Number(prompt("Veuillez saisir un premier nombre : "));
affichage += `<span>Vous avez saisi <b>${nb1}</b></span><br/>`;
nb2 = Number(prompt("Veuillez saisir un deuxième nombre : "));
affichage += `<span>Vous avez saisi <b>${nb2}</b></span><br/>`;


// Addition des deux nombres
resultat = nb1 + nb2;

// Ajout de résultat à la variable affichage
affichage += `La somme de <b>${nb1}</b> + <b>${nb2}</b> = <b>${resultat}</b> <br/>`;

// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


