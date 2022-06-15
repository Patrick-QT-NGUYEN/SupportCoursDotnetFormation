// import class Vehicule
import Vehicule from "./Vehicule.js";

// START Class Voiture
export default class Voiture extends Vehicule{
    clim:string;
    constructor(marque:string, modele:string,kilometrage:number,annee:number,clim:string="non-climatisée"){
        super(marque, modele,kilometrage,annee);
        this.clim = clim;
    }
    // Override de la méthode display()
    display(){
        return `Voiture : ${super.display()} - ${this.clim}`;
    }
}
// END Class Voiture