/**
 * EXERCICE 30 - LES STRUCTURES ITERATIVES - WHILE - Meilleure Note
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variable
let nbNotes = 0,
    maxNote = 0,
    minNote = 20,
    moyNotes = 0,
    ok = false,
    Affichage = `<h2>Meilleur note, moins bonne note, moyennes des notes</h2><br><hr>`;


// Boucle while pour la saisie et le traitement des notes
while (!ok) {
    let noteTmp = Number(prompt(`Veuillez saisir la note N°${nbNotes + 1} ( /20 ou 777 pour sortir): `));
    if (!isNaN(noteTmp)) {
        if (noteTmp >= 0 && noteTmp <= 20) {
            Affichage += `<li>En note <b>N°${nbNotes + 1}</b>, vous avez saisi <b>${noteTmp}/20</b>.</li>`;
            // Ajouter la note à la moyenne des notes
            moyNotes += noteTmp;
            // Vérification si noteTMP est supérieur à max note
            if (noteTmp > maxNote)
                maxNote = noteTmp;
            // Vérification si noteTMP est supérieur à max note
            if (noteTmp < minNote)
                minNote = noteTmp;
            nbNotes++;
        }
        else if(noteTmp === 777)
            ok = true;        
        else
            alert("Merci de saisir une note entre 0 et 20 ou 777 pour sortir de la saisie.");
    }
    else
        alert("Merci de saisir un nombre...");
}


Affichage += "</ul><hr>";

// Calcul de la moyenne
moyNotes = Math.round(((moyNotes / nbNotes)+Number.EPSILON)*10)/10;

// Affichage des résultat
Affichage += `<p>Sur l'ensemble des <b>${nbNotes} notes</v></b> : <br></p>
            <ul>
                <li class ="green">La meilleure note est de <b>${maxNote}/20</b>.</li>
                <li class ="red">La moins bonne note est de <b>${minNote}/20</b>.</li>
                <li class ="gray">La moyenne des notes est de <b>${moyNotes}/20</b>.</li>
            </ul>
`;

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = Affichage;


