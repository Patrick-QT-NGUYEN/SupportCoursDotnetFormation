import Vehicule from "./Vehicule.js";

export default class Moto extends Vehicule{
    // constructor(ParamsMarque, ParamsModele, ParamsKilometrage, ParamsAnnee){
    //     super(ParamsMarque,ParamsModele, ParamsKilometrage, ParamsAnnee);        
    // }

    Display(){
        return ` <b>Moto :</b> ${super.Display()} `;
    }
}