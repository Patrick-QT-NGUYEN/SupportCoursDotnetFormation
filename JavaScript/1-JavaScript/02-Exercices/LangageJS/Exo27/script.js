/**
 * EXERCICE 27 - LES STRUCTURES ITERATIVES - FOR - Etudiants Notes
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration d'un tableau d'étudiants contenant 2 étudiants
let etudiants = [
    {
        prenom: "José",
        nom: "Garcia",
        matieres: {
            Francais: 16,
            Anglais: 7,
            Humour: 14
        }
    },
    {
        prenom: "Antoine",
        nom: "De Caunes",
        matieres: {
            Francais: 15,
            Anglais: 6,
            Humour: 16,
            Informatique: 4,
            Sport: 10
        }
    }
];

// Déclaration des variable
let moyenne = 0,
    nbNotes = 0,
    Total = 0,
    affichage = `<h2>Notes des étudiants</h2><br><hr>`;

// Parcourir le tableau à 2 dimensions Etudiants
for (let etudiant of etudiants) {
    affichage += `<p> <b>${etudiant.prenom} ${etudiant.nom}</b> </p><ul>`;
    Total = 0;
    nbNotes = 0;
    for (let key in etudiant.matieres) {
        affichage += `<li> ${key} : <b>${etudiant.matieres[key]}/20</b></li>`;
        // Total des notes
        Total += etudiant.matieres[key];
        nbNotes++;
    }

    // calcul de la moyenne
    moyenne = Math.round(((Total / nbNotes) + Number.EPSILON)*10)/10;
    affichage += `</ul><br> Moyenne générale de l'élève : <b>${moyenne}/20</b><br><hr>`
}




// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = affichage;

