export default class Contact{
    constructor(nom,prenom,email,telephone){
        this.nom = nom;
        this.prenom = prenom;
        this.email = email;
        this.telephone = telephone;
    }

    Display = () =>{
        return `${this.nom} ${this.prenom} - Email : ${this.email} - Téléphone : ${this.telephone}`;
    }
}