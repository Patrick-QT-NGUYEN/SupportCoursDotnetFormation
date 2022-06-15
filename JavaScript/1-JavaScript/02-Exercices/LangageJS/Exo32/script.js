/**
 * EXERCICE 32 -  LES FONCTIONS() - Calcul Périmètre
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration de la fonction() Périmetre()
function Perimetre(longeur, largeur){
    // Déclaration d'une variable locale resulatat pous stocker le résultat du calcul
    let resultat = (longeur + largeur)*2;
    // La fonction retourne la valeur de la variable resultat
    return resultat;
}

// Récupération des saisies de l'utilisateur
let nb1 = Number(prompt("Veuillez saisir la longeur : "));
let nb2 = Number(prompt("Veuillez saisir la largeur : "));

// Déclaration d'une variable périmetre pour stocker le calcul de la fonction Périmetre
let perimetre = Perimetre(nb1,nb2);

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML =`<br> <p class="lead">Le périmètre de votre rectangle est :<b> ${perimetre} cm</b>`;


