/**
 * EXERCICE 16 - LES STRUCTURES CONDITIONNELLES - If...Else... Quel sera le montant de la prime de licenciement ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var salaire = 0,
    anciennete = 0,
    age = 0,
    indemnite = 0,
    affichage = "";


// Récupération des saisies utilisateur pour le salaire, anciennete et age
salaire = Number(prompt("Veuillez saisir votre dernier salaire (en €) : "));
anciennete = Number(prompt("Veuillez saisir votre anciennete (en année(s)) : "));
age = Number(prompt("Veuillez saisir votre age (en année(s)) : "));



// Mise en place d'une structure conditionnelle pour calculer la prime

/**
 * Prime liee à l'ancienneté
 */
if (anciennete >= 1 && anciennete <= 10)
    indemnite += (salaire / 2) * anciennete;
else if (anciennete > 10) {
    indemnite += (salaire / 2) * 10;
    indemnite += salaire * (anciennete - 10);
}

/**
 * Calcul de la Prime liée à l'age
 */
// avec une structure conditionnelle classique
if (age > 45 && anciennete >= 1) {
    if (age >= 50)
        indemnite += 5 * salaire;
    else
        indemnite += 2 * salaire;
}

// // Avec un ternaire (sugar syntaxe)
// if (age > 45 && anciennete >= 1)
//     indemnite += age < 50 ? 2 * salaire : 5 * salaire



// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = `Le montant de l'indémnité pour un salarié de <b>${age} ans</b>, un dernier salaire de <b>${salaire}€</b> et avec <b>${anciennete} année(s)</b> d'ancienneté s'élève à <b>${indemnite}€</b>`;


