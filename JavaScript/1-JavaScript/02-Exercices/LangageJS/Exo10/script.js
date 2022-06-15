/**
 * EXERCICE 10 - LES STRUCTURES CONDITIONNELLES - If...Else... Test de connection
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Constante pour l'email et password
const email = "contact@teamjs.fr";
const mdp = "leLundiAuSoleil";

// Affichage du titre dans le HTML
var affichage = `<br/><h3>Test de connection</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
var userEmail = prompt("Veuillez votre email : ");
var userPassword = prompt("Veuillez saisir votre mot de passe : ");

//// Etablissement d'une structure conditionnelle pour la vérification de l'email et du mdp
// if (userEmail === email)
// {
//     if(userPassword === mdp)    
//         affichage +=`Bienvenu sur votre espace sécurisé`;
//     else
//         affichage +=`Mot de passe incorect!`;   
// }
// else
//     affichage +=`Email inconnue!`;

// // Avec des connecteurs logiques
// if(userEmail===email && userPassword===mdp)
//     affichage +=`Bienvenu sur votre espace sécurisé`;  
// else
//     affichage +=`Erreur email et/ou password`; 

// Avec un ternaire (Sugar Syntaxe) => test logique ? reponse si vrai : réponse si faux;
affichage += userEmail===email && userPassword===mdp ? "Bienvenu sur votre espace sécurisé" : "Erreur email et/ou password";


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


