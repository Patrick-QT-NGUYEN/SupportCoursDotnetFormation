/**
 * LES TABLEAUX A DEUX DIMENSIONS
 */

// Déclaration de deux tableaux
var legumes = ["Poireaux", "Concombre","Epinard"];
var fruits = new Array("Raisin", "Bananes","Abricots","Cerise");

// Affichage des deux tableaux
console.table(legumes);
console.table(fruits);

// Création d'un tableau à deux dimensions depuis les deux tableaux numériques
var primeur = new Array(legumes,fruits);

// Affichage du tableau à deux dimension
console.table(primeur);

// Affichage de poireaux
console.log(primeur[0][0]);

// Affichage de Abricots
console.log(primeur[1][2]);

// Avec des tableau associatif
var zoo =[
    {
        pseudo:"Simba",
        espece:"Lion",
        continent:"Afrique"
    },
    {
        pseudo:"Tony",
        espece:"Kangourou",
        continent:"Océanie"
    }
];

console.table(zoo);

// Afficher dans la console le pseudo du lion et du kangourou (avec mise en forme)
console.log("Venez découvrir dans notre zoo " + zoo[0]["pseudo"] + " est " + zoo[1].pseudo ) ;



