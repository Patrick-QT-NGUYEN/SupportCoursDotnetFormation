
export default class Vehicule{
    constructor(ParamsMarque, ParamsModele, ParamsKilometrage, ParamsAnnee){
        this.Marque = ParamsMarque;
        this.Modele = ParamsModele;
        this.Kilometrage = ParamsKilometrage;
        this.Annee = ParamsAnnee;
    }

    Display(){
        return `${this.Marque} - ${this.Modele} - ${this.Kilometrage}km - ${this.Annee}`;
    }
}