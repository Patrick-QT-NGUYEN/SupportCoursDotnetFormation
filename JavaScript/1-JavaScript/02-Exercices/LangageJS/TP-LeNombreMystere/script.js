/**
 * TP Le Nombre Mystere
 */

// Récupération des elements du DOM
const ligne1 = document.querySelector('#ligne1');
const ligne2 = document.querySelector('#ligne2');
const nbCoupsHTML = document.querySelector('#nbCoups');
const nbUser = document.querySelector('#nbUser');
const ValiderBtn = document.querySelector('#validerBtn');

// Déclaration des variables
let nombre = 0,
    nbMystere = 0,
    nbCoups = 0;



/**
 * Déclaration des fonction() 
 */ 

// Déclaration d'une fonction pour incrémenter le compteur et pour actualiser le nombre de coups dans l'HTML
function updateNbCoups() {
    nbCoups++;
    nbCoupsHTML.textContent = " " + nbCoups;
}

function StartGame() {
    // Initialisation des champs HTML
    nbCoupsHTML.textContent = " " + nbCoups;
    ligne1.textContent = "J'ai généré un nombre entre 1 et 50 inclus";
    ligne2.textContent = "Essayez de deviner en proposant ci-dessous";
    ValiderBtn.disabled = false;
    // Réinitialisation des variables
    nombre = 0;
    nbCoups = 0;
    nbCoupsHTML.textContent = " " + nbCoups;
    // Génération du nombre mystere
    nbMystere = Math.floor(Math.random() * 50) + 1;
    //alert(nbMystere);
}

function EndGame() {
    ligne1.textContent = `Bravo !!! Vous avez trouvé en ${nbCoups} coups`;
    ligne2.textContent = `Le nombre mystere était ${nbMystere}`;
    ValiderBtn.disabled = true;
}


function Valider() {
    //alert("Valider"); // Vérification de la propagation de l'evenement click

    // Récupération de la saisie de l'utilisateur
    let nbTmp = parseInt(nbUser.value);
    // console.log(typeof(nbTmp));
    // console.log(nbTmp);
    updateNbCoups();
    if (nbTmp == nbMystere) {
        EndGame();
    }
    else if (nbTmp < nbMystere) {
        ligne1.textContent = `le nombre mystère est plus grand que ${nbTmp}`;
    }
    else {
        ligne1.textContent = `le nombre mystère est plus petit que ${nbTmp}`;

    }
    nbUser.value = "";
}

document.addEventListener("keyup", function (event) {
    if (event.key === "Enter" && nbUser.value !== "") {
        Valider();
    }
})

function Rejouer() {
    //alert("Rejouer"); // Vérification de la propagation de l'evenement click
    //window.location.reload();
    StartGame();
}

window.onload = StartGame();



