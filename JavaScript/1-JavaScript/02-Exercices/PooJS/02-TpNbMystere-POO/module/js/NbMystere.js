import NumGenerator from './NumGenerator.js';
export default class NbMystere {
    constructor() {
        this.numMystere = this.GenerateNbMystere();
        this.nbCoups = 0;
        this.win = false;
    }

    GenerateNbMystere() {
        let generator = new NumGenerator();
        return generator.generateNumber(1, 50)
    }

    TestNumber(userNum) {
        if (!isNaN(userNum)) {
            this.nbCoups++;
            if (userNum === this.numMystere) {
                this.win = true;
                return `Bravo!!! Vous avez trouvé en ${this.nbCoups}`;
            }
            else if (userNum < this.numMystere)
                return `le nombre mystère est plus grand que ${userNum}`;
            else
                return `le nombre mystère est plus petit que ${userNum}`;
        }
        else
            return 'Veuillez saisir un nombre'
    }
}