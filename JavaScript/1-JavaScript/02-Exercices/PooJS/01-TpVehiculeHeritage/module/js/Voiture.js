import Vehicule from "./Vehicule.js";

export default class Voiture extends Vehicule{
    constructor(ParamsMarque, ParamsModele, ParamsKilometrage, ParamsAnnee, ParamsClim){
        super(ParamsMarque,ParamsModele, ParamsKilometrage, ParamsAnnee);
        this.clim = ParamsClim;
    }

    Display(){
        return ` <b>Voiture :</b> ${super.Display()} - ${this.clim?"Climatisée":"Non-Climatisée"}`;
    }
}