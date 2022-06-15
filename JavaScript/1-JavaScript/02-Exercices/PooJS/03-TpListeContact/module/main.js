import Contact from './js/Contact.js';

//Création des constantes permettant la récupération d'element HTML
const tableau = document.querySelector('#tableau');
const ValiderBtn = document.querySelector('#validerBtn');

// Declaration des variables globale
let contacts = [];

function createFakeContact() {
    // Création d'un tableau de personnes à deux dimensions
    let annuaire = [
        {
            titre: "Mr",
            nom: "Dupont",
            prenom: "Jean",
            dateNaissance: "1973,10,08",
            telephone: "+(33)6 12 36 54 78",
            email: "jdupont@gmail.com"
        },
        {
            titre: "Mme",
            nom: "Doe",
            prenom: "Jeanne",
            dateNaissance: "1985,02,24",
            telephone: "+(33)6 45 23 87 14",
            email: "jdoe@yahoo.fr"
        },
        {
            titre: "Mr",
            nom: "Martin",
            prenom: "Jacques",
            dateNaissance: "1933,06,22",
            telephone: "+(33)6 78 45 24 95",
            email: "jmartin@petitrapporteur.fr"
        }
    ];
    for (let contact of annuaire) {
        // let cTmp = new Contact(contact.titre, contact.nom, contact.prenom,new Date(contact.dateNaissance).toLocaleDateString(),contact.telephone,contact.email);
        // contacts.push(cTmp);

        contacts.push(new Contact(contact.titre, contact.nom, contact.prenom, new Date(contact.dateNaissance).toLocaleDateString(), contact.telephone, contact.email));
    }
    insertList();
}

function insertList() {
    tableau.innerHTML = "";
    for (let contact of contacts) {
        tableau.innerHTML += `<tr>
                                <td>${contact.titre}</td>
                                <td>${contact.nom}</td>
                                <td>${contact.prenom}</td>
                                <td>${contact.dateNaissance}</td>
                                <td>${contact.telephone}</td>
                                <td>${contact.adresse}</td>        
                            </tr>`;
    }
}

function resetForm() {
    document.querySelector('#nom').value = "";
    document.querySelector('#prenom').value = "";
    document.querySelector('#dateNaissance').value = "";
    document.querySelector('#telephone').value = "";
    document.querySelector('#email').value = "";
}

ValiderBtn.onclick = () => {


    // Récupération des saisies de l'utilisateur
    const nom = document.querySelector('#nom').value;
    const prenom = document.querySelector('#prenom').value;
    const dateNaissance = document.querySelector('#dateNaissance').value;
    const telephone = document.querySelector('#telephone').value;
    const email = document.querySelector('#email').value;
    // Titre
    let titre = document.getElementById("Mr").checked ? "Mr" : "Mme";

    contacts.push(new Contact(titre, nom, prenom, new Date(dateNaissance).toLocaleDateString(), telephone, email));
    insertList();
    resetForm();
}

window.onload = createFakeContact();