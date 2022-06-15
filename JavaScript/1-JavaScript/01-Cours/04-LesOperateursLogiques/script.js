/**
 * LES OPERATEURS LOGIQUES
 */

// Déclaration d'une constante détenant un element du DOM
const result = document.querySelector('#result');

/*
    L'opérateur ET = &&
*/
// Exemple de vérification si un nombre se situe dans un range de valeur
var resultat="";
var nbUser;
nbUser = Number(prompt("Veuillez saisir un nombre entre 1 et 3 inclus: "));

if(nbUser >=1 && nbUser<=3){
    resultat += `Le nombre ${nbUser} est bien supérieur ou égal à 1 et inférieur ou égal à 3<br/>`;
}else{
    resultat += `Le nombre ${nbUser} n'est pas supérieur ou égal à 1 et inférieur ou égal à 3<br/>`;
}

console.log(resultat);
result.innerHTML = resultat;

/*
    L'opérateur OU = ||
*/
// Exemple de vérification si un nombre est bien inférieur à 1 ou supérieur à 3
nbUser = Number(prompt("Veuillez saisir un nombre : "));

if(nbUser < 1 || nbUser > 3){
    resultat += `Le nombre ${nbUser} est bien supérieur à 3 ou inférieur à 1<br/>`;
}else{
    resultat += `Le nombre ${nbUser} n'est pas supérieur à 3 ou inférieur à 1<br/>`;
}

console.log(resultat);
result.innerHTML = resultat;

/*
    L'opérateur logique Non = !
*/

var pause = true;

if(!pause){
    resultat += "Ce n'est pas la pause\n";
}
else{
    resultat += "<p>C'est la pause ! :) Youhou dit Mathieu...<br/></p>";
}

console.log(resultat);
result.innerHTML = resultat;
