/**
 * EXERCICE 18 - LES STRUCTURES CONDITIONNELLES - SWITCH - Quelle boisson vais-je prendre ?
 */

// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');

// Constante pour le menu
const menu = `***** DISTRIBUTEUR DE BOISSON *****
                    1) Eau
                    2) Jus d'orange
                    3) Limonade
                    4) Café
                    5) Thé
                    
                    Faites votre choix : `;

// Déclaration des variables
var choix = "",
    boisson = "",
    affichage = "",
    erreur = false;

// Insertion du titre
affichage = "<h3>Quelle boisson vais-je prendre ?</h3><br/>";

// Récupération du choix de l'utilisateur
choix = prompt(menu);
//console.log(choix);

// Mise en place d'un switch pour le choix de l'utilisateur
switch (choix) {
    case "1":
        boisson ="Eau";
        break;
    case "2":
        boisson ="Jus d'Oranges";
        break;
    case "3":
        boisson ="Limonade";
        break;
    case "4":
        boisson ="Café";
        break;
    case "5":
        boisson ="Thé";
        break;
    default:
        affichage += "Erreur de choix";
        erreur = true;
        break;
}
// Si la variable booléenne erreur est différente de "true" (vrai)
if(!erreur){
    // Affichage du menu
    affichage += `***** DISTRIBUTEUR DE BOISSON *****<br/>
                    1) Eau<br/>
                    2) Jus d'orange<br/>
                    3) Limonade<br/>
                    4) Café<br/>
                    5) Thé<br/>
                    <br/>
                    Faites votre choix : <b>${choix}</b> <br/>
                    <br/>
                    Votre <b>${boisson}</b> est servi(e)...`
}

// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML = affichage;