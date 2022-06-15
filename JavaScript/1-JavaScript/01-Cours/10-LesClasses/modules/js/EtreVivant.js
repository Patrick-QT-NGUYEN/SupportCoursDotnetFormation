

export default class EtreVivant{

    constructor(ParamsNom, ParamsPrenom){
        this.nom = ParamsNom;
        this.prenom = ParamsPrenom;
    }

    Naissance() {
        console.log("Tous les êtres vivant naissent...");
    }
    Mort() {
        console.log("Tous les êtres vivant meurent...");
    }
    Respiration() {
        console.log("Tous les êtres vivant respirent...");
    }
    Alimentation() {
        console.log("Tous les êtres vivant s'alimentent... à leur manière!");
    }
}

// export default EtreVivant;