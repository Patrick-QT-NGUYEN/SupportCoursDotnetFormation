import EtreVivant from "./EtreVivant.js";

export default class Mammifere extends EtreVivant{
    constructor(Paramsnom, Paramstype){
        super(Paramsnom,Paramstype);
        this.heartRate = false;
        this.Naissance();
    }

    Naissance(){
        this.heartRate = true;
        console.log("Naissance après une période de gestation...");
    }
    Mort(){
        this.heartRate = false;
        console.log("Mon coeur s'arrete de battre... je meurs!");
    }
    
}