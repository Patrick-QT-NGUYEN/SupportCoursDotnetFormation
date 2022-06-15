import Vegetaux from './Vegetaux.js';

export default class Fleur extends Vegetaux {

    constructor( nom, type) {
        super(nom,type);
        //this.Naissance();
    }

    Naissance(){
        super.Naissance();
        console.log("Je viens d'une graine.... ou d'un bulbe!");
    }

}