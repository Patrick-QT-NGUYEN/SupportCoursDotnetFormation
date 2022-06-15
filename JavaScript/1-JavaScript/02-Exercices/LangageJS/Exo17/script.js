/**
 * EXERCICE 17 - LES STRUCTURES CONDITIONNELLES - If...Else... Quel montant dois-je payer ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var revenus = 0,
    nbAdulte = 0,
    NbEnfant = 0,
    nbParts = 0,
    RevenuFiscalReference = 0,
    montantImpot = 0;


// Récupération des saisies utilisateur pour le revenu est les nombre de personnes
revenus = Number(prompt("Veuillez saisir le revenu brute du foyer (en €) : "));
nbAdulte = Number(prompt("Veuillez saisir le nombre d'adulte(s) du foyer : "));
NbEnfant = Number(prompt("Veuillez saisir le nombre enfant(s) du foyer : "));


// Calcul du nombre de part
if (NbEnfant <= 2)
    nbParts = nbAdulte + NbEnfant * 0.5;
else
    nbParts = nbAdulte + NbEnfant - 1;

//console.log(nbParts);
// Calcul du RFR
RevenuFiscalReference = revenus / nbParts;
//console.log(RevenuFiscalReference);

// Mise en place d'une structure conditionnelle pour calculer le monta,nt brut de l'impôt
if (RevenuFiscalReference >= 10226 && RevenuFiscalReference <= 26070)
    montantImpot = Math.round((RevenuFiscalReference - 10225) * 0.11);
else if (RevenuFiscalReference >= 26071 && RevenuFiscalReference <= 74545)
    montantImpot = Math.round(((RevenuFiscalReference - 26070) * 0.30) + ((26070 - 10226) * 0.11));
else if (RevenuFiscalReference >= 74546 && RevenuFiscalReference <= 160336)
    montantImpot = Math.round(((RevenuFiscalReference - 74545) * 0.41) + ((74545 - 26071) * 0.3) + ((26070 - 10226) * 0.11));
else if (RevenuFiscalReference >= 160337)
    montantImpot = Math.round(((RevenuFiscalReference - 160336) * 0.45) + ((160336 - 74546) * 0.41) + ((74545 - 26071) * 0.3) + ((26070 - 10226) * 0.11));


// // Sugar Syntaxe
// if (revenuImposable > 10064) {
//     montantImpot += (revenuImposable > 25659) ? ((revenuImposable > 73369) ? ((revenuImposable > 157806) ?
//         ((revenuImposable - 157806) * 0.45) + ((157806 - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11)
//         : ((revenuImposable - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11))
//         : ((revenuImposable - 25659) * 0.3) + ((25659 - 10064) * 0.11))
//         : (revenuImposable - 10064) * 0.11;
// }


// Calcul du montant net de l'impot
//console.log(montantImpot);
montantImpot = montantImpot * nbParts;




// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = `Le montant de l'impôt sur le revenu pour un foyer compsé de <b>${nbAdulte} adultes</b> et <b>${NbEnfant} enfants</b>, avec un renenu brute de <b>${revenus}€</b> s'élève à <b>${montantImpot}€</b>`;


