/**
 * EXERCICE 31 - LES COLLECTIONS - TABLEAUX - Annuaire
 */


// Création de la constante result permettant de recupérer l'élément HTML id="result"
const result = document.querySelector('#result');
const tableau = document.querySelector('#tableau');

// Création d'un tableau de personnes a deux dimensions
let annuaire = [
    {
        nom: "Dupont",
        prenom: "Jean",
        age: 15
    },
    {
        nom: "Durant",
        prenom: "Pierre",
        age: 16
    },
    {
        nom: "Martin",
        prenom: "Jean",
        age: 17
    }
];

// Insertion des en-tete de colonnes du tableau
tableau.innerHTML +=`
                    <thead>
                        <th class="title">Prénom</th>
                        <th class="title">Nom</th>
                        <th class="title">Age</th>
                    </thead>`;

for(let contact of annuaire){
    tableau.innerHTML+=`<tr>
                            <td>${contact.prenom}</td>
                            <td>${contact.nom}</td>
                            <td>${contact.age}</td>
                        </tr>`;
}

// Affichage du résultat dans la console
console.table(annuaire);
console.log(annuaire[1].prenom + " " + annuaire[1].nom);





// Affichage du contenu de la variable indemnité dans l'element HTML #result
result.innerHTML =`<br> <p class="lead">La personne à la <b>2eme position</b> de l'annuaire est : </p>
                    <b>${annuaire[1].prenom} ${annuaire[1].nom}</b>`;


