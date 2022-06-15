/**
 * LES TABLEAUX NUMERIQUE EN JS
 */

// Déclaration d'un tableau numértique en JS (2 façons)
var monTableau = new Array();
var monAutreTableau = [];

// Affecter une valeur à un tableau numérique
monTableau[0]= "Pomme"; // Affectation de la valeur Pomme en index 0
monTableau[1]= "Poire"; // Affectation de la valeur Poire en index 1

// Affichage du contenu d'un tableau dans la console
console.table(monTableau);

// Affichage d'une valeur à index 
console.log("A l'index 1 : "+monTableau[1]);

// Déclaration et affectation e valeur en même temps
var legumes = ["Carotte", "Choux", "Haricot"];
// Equivalent à var legumes = new Array("Carotte", "Choux", "Haricot");

// Affichage du tableau de légumes
console.table(legumes);
console.log(legumes);

// Réaffecter une valeur dans le tableau
console.log(legumes[2]); // Affiche la valeur à l'index 2
legumes[2]="Epinard";    // Modifie la valeur à l'index 2
console.log(legumes[2]); // Affiche la valeur à l'index 2

// Récuperer la taille de la collection
console.log("La longeur du tableau est : " + legumes.length);
console.table(legumes);


// Ajouter un ou plusieurs elements à un tableau push()
legumes.push("Courgette");
console.table(legumes);
legumes.push("Potiron","Aubergine");
console.table(legumes);

// Méthode pour retirer le dernier element du tableau pop()
legumes.pop();
console.table(legumes);

// Méthode pour retirer le premier element du tableau shift()
legumes.shift();
console.table(legumes);

// Ajouter un ou plusieurs elements à un tableau push()
legumes.push("Courgette");
console.table(legumes);
legumes.push("Potiron","Aubergine");
console.table(legumes);

// Retirer un ou plusieurs éléments d'un tableau à un index donné splice(index, nb)
legumes.splice(4,2);
console.table(legumes);

// Ajouter des éléments à une position donnée splice(index, nb, value)
legumes.splice(3,0,"Concombre","Tomate");
console.table(legumes);

// Connaitre l'index d'un élément
console.log(legumes.indexOf('Radis'));

// Récupérer un element d'un tableau et stockage dans une variable (Tomate)
var monLegume;
var index = legumes.indexOf('Radis');
if(index>=0){
    monLegume = legumes[index];
    console.log(monLegume);
}
else{
    alert("Ce légume n'existe pas");
}