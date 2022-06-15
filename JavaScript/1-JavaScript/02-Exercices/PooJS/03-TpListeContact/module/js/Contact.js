export default class Contact{
    constructor(titre,nom,prenom,dateNaissance,telephone,adresse){
        this.titre = titre;
        this.nom = nom;
        this.prenom = prenom;
        this.dateNaissance = dateNaissance;
        this.telephone = telephone;
        this.adresse = adresse;
    }

    getContact = () =>`${this.titre} ${this.nom} ${this.prenom} ${this.dateNaissance} ${this.telephone} ${this.adresse}`;
} 