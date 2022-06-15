/**
 * EXERCICE 33 -  LES FONCTIONS() - Meilleure Note
 */

// Création de la constante result permettant de recupérer l'élément HTML
const result = document.querySelector('#result');
const menu = document.querySelector('#menu');
const notes = document.querySelector('#notes');

// Déclaration des variables
let nbNotes = 0,
    maxNote = 0,
    minNote = 20,
    moyNotes = 0,
    ok = false;

/**
 * DECLARATION DES FONCTIONS
 */

function Menu() {
    return `<button onClick="SetNotes()" class="btn btn-primary">Saisir les notes</button>
            <button onClick="ShowBetter()" class="btn btn-success">Voir la meilleure note</button>
            <button onClick="ShowWorst()" class="btn btn-danger">Voir la moins bonne note</button>
            <button onClick="ShowAvg()" class="btn btn-secondary">Voir la moyenne des notes</button>`;
}

function resetAll() {
    nbNotes = 0,
        maxNote = 0,
        minNote = 20,
        moyNotes = 0,
        ok = false;
    result.innerHTML = "";
    notes.innerHTML = "";
}

function SetNotes() {

    resetAll();
    // while(ok !== true)
    // while (ok === false)
    while (!ok) {
        let noteTmp = Number(prompt(`Veuillez saisir la note N°${nbNotes + 1} ( /20 ou 777 pour sortir): `));
        if (!isNaN(noteTmp)) {
            if (noteTmp >= 0 && noteTmp <= 20) {
                result.innerHTML += `<li>En note <b>N°${nbNotes + 1}</b>, vous avez saisi <b>${noteTmp}/20</b>.</li>`;
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
            else if (noteTmp === 777)
                ok = true;
            else
                alert("Merci de saisir une note entre 0 et 20 ou 777 pour sortir de la saisie.");
        }
        else
            alert("Merci de saisir un nombre...");
    }
}

function ShowBetter() {
    notes.innerHTML = `<h3 class="green">La meilleur note est de <b>${maxNote}/20</b></h3>`;
}

function ShowWorst() {
    notes.innerHTML = `<h3 class="red">La moins bonne note est de <b>${minNote}/20</b></h3>`;
}

function ShowAvg() {
    // Calcul de la moyenne
    moyNotes = Math.round(((moyNotes / nbNotes) + Number.EPSILON) * 10) / 10;
    notes.innerHTML = `<h3 class="gray">La moyenne des notes est de <b>${moyNotes}/20</b></h3>`;
}

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = ``;

function Init() {
    menu.innerHTML = Menu();
}

// Declencher une fonction au lancement de la page
window.onload = Init();
