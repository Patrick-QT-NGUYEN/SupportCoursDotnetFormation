/**
 * TP Le Nombre Mystere
 */

import NbMystere from './js/NbMystere.js';

// Récupération des elements du DOM
const ligne1 = document.querySelector('#ligne1');
const ligne2 = document.querySelector('#ligne2');
const nbCoupsHTML = document.querySelector('#nbCoups');
const nbUser = document.querySelector('#nbUser');
const ValiderBtn = document.querySelector('#validerBtn');
const RejouerBtn = document.querySelector('#rejouerBtn');

// Ratachement à la propirèté onclick des buttons les fonctions correpondante
ValiderBtn.onclick = () => Valider();
RejouerBtn.onclick = () => Rejouer();

// Déclaration des variables globale
let jeu = new NbMystere();

/**
 * Déclaration des fonction() 
 */

// Déclaration d'une fonction pour incrémenter le compteur et pour actualiser le nombre de coups dans l'HTML
function updateNbCoups() {
    nbCoupsHTML.textContent = " " + jeu.nbCoups;
}

function StartGame() {
    // Initialisation des champs HTML
    nbCoupsHTML.textContent = " " + jeu.nbCoups;
    ligne1.textContent = "J'ai généré un nombre entre 1 et 50 inclus";
    ligne2.textContent = "Essayez de deviner en proposant ci-dessous";
    ValiderBtn.disabled = false;
    ValiderBtn.textContent = "Valider";
    jeu = new NbMystere();
    updateNbCoups();
    
}

function EndGame() {
    ligne2.textContent = `Le nombre mystere était ${jeu.numMystere}`;
    ValiderBtn.textContent = "End";
    ValiderBtn.disabled = true;
}


function Valider() {    
    // Récupération de la saisie de l'utilisateur
    let nbTmp = parseInt(nbUser.value);
    // Affichage du message rtourné par la fonction testNumber()
    ligne1.textContent = jeu.TestNumber(nbTmp);

    // Raffraichier le nombre de copups affiché dans le front
    updateNbCoups();
    // Vérifie si la partie est gagnée
    if(jeu.win){
        EndGame();
    }
    // reset le user input
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



