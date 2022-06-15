export default class Vehicule{

    marque:string;
    modele:string;
    kilometrage:number;
    annee:number;
    
    constructor(marque:string, modele:string,kilometrage:number,annee:number){
        this.marque = marque;
        this.modele = modele;
        this.kilometrage = kilometrage;
        this.annee = annee;
    }

    display():string{
        return `${this.marque} - ${this.modele} - ${this.kilometrage}km - ${this.annee}`;
    }
}
