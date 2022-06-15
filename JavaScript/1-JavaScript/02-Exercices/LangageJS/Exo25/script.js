/**
 * EXERCICE 25 - LES STRUCTURES ITERATIVES - FOR - Chaines Entiers
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variable
let nombre = 0,
    Affichage = "",
    debut,
    fin,
    temps = "";


// Déclaration des variables
Affichage += `<h2>Chaîne d'entiers</h2>`;

// Récupératuion du nombre de l'utilisateur
nombre = Number(prompt("Veuillez saisir un nombre entier"));

// Affichage de la saisie utilisateur
Affichage += nombre >= 0 && nombre < 10 ? `<p>Vous avez saisi le chiffre <b>${nombre}</b></p>` : `<p>Vous avez saisi le nombre <b>${nombre}</b></p>`;

// Verifier si l'utilisateur a saisi un nombre
if (!isNaN(nombre)) {
    Affichage += `<p>Voici la liste d'entiers chaîné dont la somme est égale à <b>${nombre}</b></p><ul>`;
    // Métrique du code
    console.time(temps);

    for (let i = 1; i <= nombre / 2 + 1; i++) {
        let chaine = `${nombre} = ${i}`;
        let somme = i;
        for (let j = i + 1; j <= nombre / 2 + 1; j++) {
            somme += j;
            chaine += ` + ${j}`;
            // console.log("Somme = " +somme);
            // console.log("chaine = " +chaine);

            if (somme === nombre) {
                Affichage += `<li>${chaine}</li>`;
                break;
            }
            else if (somme > nombre) {
                break;
            }
        }
    }
    // Métrique du code
    console.timeEnd(temps);

    Affichage += "</ul>";
}

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

