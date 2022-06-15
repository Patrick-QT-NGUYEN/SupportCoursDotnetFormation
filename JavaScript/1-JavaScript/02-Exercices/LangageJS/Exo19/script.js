/**
 * EXERCICE 19 - LES STRUCTURES CONDITIONNELLES - SWITCH - Quelle taille me correspond ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var taille = 0,
    poids = 0,
    affichage = "";


// Récupération des saisies utilisateur pour les taille et poids
taille = Number(prompt("Veuillez saisir votre taille (en cm) : "));
poids = Number(prompt("Veuillez saisir votre poids (en kg) : "));



// Mise en place d'une structure conditionnelle SWITCH pour vérifier la taille correspondante
switch (true) {
    case (taille >= 145 && taille < 172 && poids >= 43 && poids <= 47 ||
        taille >= 145 && taille < 169 && poids >= 48 && poids <= 53 ||
        taille >= 145 && taille < 166 && poids >= 54 && poids <= 59 ||
        taille >= 145 && taille < 163 && poids >= 60 && poids <= 65):
        affichage += `Prennez la taille 1`;
        break;
    case (taille >= 169 && taille < 183 && poids >= 48 && poids <= 53 ||
        taille >= 166 && taille < 178 && poids >= 54 && poids <= 59 ||
        taille >= 163 && taille < 175 && poids >= 60 && poids <= 65 ||
        taille >= 160 && taille < 172 && poids >= 66 && poids <= 71):
        affichage += `Prennez la taille 2`;
        break;
    case (taille >= 178 && taille < 184 && poids >= 54 && poids <= 59 ||
        taille >= 175 && taille < 184 && poids >= 60 && poids <= 65 ||
        taille >= 172 && taille < 184 && poids >= 66 && poids <= 71 ||
        taille >= 163 && taille < 184 && poids >= 72 && poids <= 77):
        affichage += `Prennez la taille 3`;
        break;
    default:
        affichage += `Aucune taille ne vous correspond.`;
        break;
}

// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = `Pour <b>${taille}cm</b> et <b>${poids}kg</b> : <br/>
                    <ul>
                        <li>${affichage}</li>
                    </ul>
                    `;
