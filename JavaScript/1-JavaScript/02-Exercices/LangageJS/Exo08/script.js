/**
 * EXERCICE 08 - LES VARIABLES ET OPERATEURS ARITHMETIQUES - Calcul du montant de T.V.A
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Déclaration des variables
var prixHT = 0,
    taux = 0,
    montantTVA,
    prixTTC = 0,
    affichage = "";

// Affichage du titre dans le HTML
affichage += `<br/><h3>Calcul du prix TTC d'un objet et du montant de T.V.A</h3>`;

// Récupération des saisies utilisateur pour le coté du carré
prixHT = Number(prompt("Veuillez saisir le prix d'achat H.T de l'objet (en €) : "));
taux = Number(prompt("Veuillez saisir le taux de T.V.A applicable : "));

// Calcul de la T.V.A et du montant T.T.C
montantTVA = prixHT * (taux / 100);
prixTTC = prixHT + montantTVA;

// Affichage des résultat dans le HTML
affichage += `<div>le prix d'achat H.T étant de <b>${prixHT}€</b>,avec un taux de T.V.A applicable de <b>${taux}%,</b></div>
<ul>
    <li>Le montant de la T.V.A s'élevera à <b>${montantTVA}€</b></li>
    <li>Le prix T.T.C de l'objet sera de <b>${prixTTC}€</b></li>
</ul>
`;


// Affichage du contenu de la variable affichage dans l'element HTML #result
result.innerHTML = affichage;


