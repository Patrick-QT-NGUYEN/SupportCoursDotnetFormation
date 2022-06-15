// import class Vehicule
import Vehicule from "./Vehicule.js";

// START Class Moto
export default class Moto extends Vehicule{
    // Override de la méthode display()
    display():string{
        return`Moto : ${super.display()}`;
    }
}
// END Class Moto