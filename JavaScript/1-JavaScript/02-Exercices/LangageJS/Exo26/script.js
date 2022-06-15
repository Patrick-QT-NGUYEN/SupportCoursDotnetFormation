/**
 * EXERCICE 26 - LES STRUCTURES ITERATIVES - FOR - Meilleure Note
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variable
let nbNotes = 0,
    maxNote = 0,
    minNote = 20,
    moyNotes = 0,
    Affichage = `<h2>Meilleur note, moins bonne note, moyennes des notes</h2><br><hr>`;

// Récupération du nombre de note souhaité par  l'utilisateur
nbNotes = Number(prompt("Veuillez saisir le nombre de notes : "));

// Affichage de la saisie utilisateur
Affichage += `<p>La serie contient <b>${nbNotes} notes</b></p><ul>`;

// Boucle pour récupérer la saise des notes et effectuer leur traitement
for (let i = 1; i <= nbNotes; i++) {
    let noteTmp = Number(prompt(`Veuillez saisir la note N°${i} : `));
    Affichage += `<li>En note <b>N°${i}</b>, vous avez saisi <b>${noteTmp}/20</b>.</li>`;
    // Ajouter la note à la moyenne des notes
    moyNotes += noteTmp;
    // Vérification si noteTMP est supérieur à max note
    if (noteTmp > maxNote)
        maxNote = noteTmp;
    // Vérification si noteTMP est supérieur à max note
    if (noteTmp < minNote)
        minNote = noteTmp;
}
Affichage += "</ul><hr>";

// Calcul de la moyenne
moyNotes = moyNotes / nbNotes;

// Affichage des résultat
Affichage+=`<p>Sur l'ensemble des <b>${nbNotes} notes</v></b> : <br></p>
            <ul>
                <li class ="green">La meilleure note est de <b>${maxNote}/20</b>.</li>
                <li class ="red">La moins bonne note est de <b>${minNote}/20</b>.</li>
                <li class ="gray">La moyenne des notes est de <b>${moyNotes}/20</b>.</li>
            </ul>
`;

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;

