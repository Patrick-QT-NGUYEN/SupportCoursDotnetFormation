/**
 * LES STRUCTURES CONDITIONNELLES
 */

/*
    L'instruction if (Si... Alors),else (Sinon)


    if(condition)
    {
        Instructions...Si vrai
    }
    else 
    {
        Instructions... Si faux
    }
*/

// Récupération de l'age de l'utilisateur et stockage de la valeur dans une variable (age)
var age;
// age = Number(prompt("Veuillez saisir votre age : "));
console.log(typeof (age));

if (age >= 18) {
    console.log(`A ${age} ans, vous êtes majeur!`);
}
else {
    console.log(`A ${age} ans, vous êtes mineur!`);
}

// Equivalent à :
if (age >= 18) {
    console.log(`A ${age} ans, vous êtes majeur!`);
} else {
    console.log(`A ${age} ans, vous êtes mineur!`);
}

// Equivalent à :
if (age >= 18)
    console.log(`A ${age} ans, vous êtes majeur!`);
else
    console.log(`A ${age} ans, vous êtes mineur!`);

/*
    Avec un nouveau test logique (Sinon... Si)
*/

var solde;
//solde = Number(prompt("Veuillez saisir le solde du compte : "));


if (solde > 0) {
    console.log(`Vous êtes créditeur !`);
} else if (solde < 0) {
    console.log(`Vous êtes débiteur!`);
} else {
    console.log(`Votre solde est nul!`);
}

// Equivaut à
if (solde > 0)
    console.log(`Vous êtes créditeur !`);
else if (solde < 0)
    console.log(`Vous êtes débiteur!`);
else
    console.log(`Votre solde est nul!`);

/**
 * Le SwitchCase
 * 
 * swtich(expression condition){
 *      case valeur1 :  
 *          // Les instructions à executer si l'expression 
 *          //de condition correspond à la valeur du case
 *          Instructions(...);
 *          break;
 *      case valeur2 :  
 *          // Les instructions à executer si l'expression 
 *          //de condition correspond à la valeur du case
 *          Instructions(...);
 *          break; 
 *      case valeurN :  
 *          // Les instructions à executer si l'expression 
 *          //de condition correspond à la valeur du case
 *          Instructions(...);
 *          break; 
 *      default:
 *          // Les instructions à executer si l'expression 
 *          // de condition ne correcpond à aucun case
 *          Instructions(...);
 *          break; 
 * }
 */


// Avec une chaine en condition
var myCondition = "Papayes";
//myCondition = prompt("Veuillez saisir un fruit : ");

switch (myCondition.toUpperCase()) {
    case "ORANGE":
        console.log("Vous avec saisi orange...");
        break;
    case "ABRICOT":
        console.log("Vous avec saisi abricot...");
        break;
    case "CERISE":
    case "PAPAYES":
        console.log("Vous avec saisi cerise et/ou papayes...");
        break;
    default:
        console.log(`Vous n'avez saisi aucun des choix prédefinis... Votre choix était ${myCondition}`);
        break;
}
console.log(myCondition);

// Avec un range de valeurs en condition
var myNumber;
myNumber = Number(prompt("Veuillez saisir un nombre : "));

switch (myNumber) {
    case 0:
        console.log(`My number vaut ${myNumber}`);
        break;
    case 1:
        console.log(`My number vaut ${myNumber}`);
        break;
    default:
        console.log(`Vous avez saisi autre chose que 0 et 1.`);
        break;
}

// Avec un range de valeurs en condition
myNumber = Number(prompt("Veuillez saisir un nombre : "));

switch (true) {
    case myNumber < 0:
        console.log("Votre chiffre / nombre est négatif");
        break;
    case myNumber > 0:
        console.log("Votre chiffre / nombre est positif");
        break;
    default:
        console.log(`Vous avez saisi 0.`);
        break;
}