/**
 * LES INPUTS ET AFFICHAGES
 */

// Création des constantes permettant de récuprer les elemnt du DOM
const result = document.querySelector('#result');
const btnValider = document.querySelector('#btnValider');

// Déclaration des variables
let firstname = "",
    lastname = "",
    age = 0;
/**
 *  Déclaration des Fonctions
 */

// Fonction pour vider les inputs
ClearInput = () =>{
    // récupération des valeure des inputs
    document.querySelector('#firstname').value ="";
    document.querySelector('#lastname').value ="";
    document.querySelector('#age').value ="";
}
function Valid(){

} 
// Fonction Valider sur Button Click
Valid = () => {
    // récupération des valeure des inputs
    firstname = document.querySelector('#firstname').value;
    lastname = document.querySelector('#lastname').value;
    age = parseInt(document.querySelector('#age').value);
    // Affichage des valeur dans la console
    console.log(firstname);
    console.log(lastname);
    console.log(age);
    // Appel de méthode pour vider le contenu des inputs
    ClearInput();
    MyDisplay(firstname, lastname, age);
}

// Fonction piur l'affichage et la concaténation des valeur
MyDisplay = (Paramsfirstname, Paramslastname, Paramsage) => {
    let chaine =`<p>Je m'appelle ${Paramsfirstname} ${Paramslastname}, et j'ai ${Paramsage}ans.</p>`;
    result.innerHTML += chaine;
}

