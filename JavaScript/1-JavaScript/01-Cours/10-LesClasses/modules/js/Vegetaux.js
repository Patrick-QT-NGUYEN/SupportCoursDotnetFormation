
import EtreVivant from "./EtreVivant.js";

export default class Vegetaux extends EtreVivant{
    constructor(Paramsnom, Paramstype){
        super(Paramsnom,Paramstype);
        this.photosynthese = false;
        this.Naissance();
    }

    Naissance(){
        this.photosynthese = true;
        console.log("Je pousse du bas vers le haut et je photosynthèse");
    }
    Mort(){
        this.photosynthese = false;
        console.log("Je fane et je ne peux plus photosynthètiser");
    }
    Alimentation(){        
        console.log("Je me nourris par les racines...Et le soleil");
    }
    Respiration(){
        console.log("le jour je rejette de l'O2, la nuit je rejette du CO2.");
    }
}