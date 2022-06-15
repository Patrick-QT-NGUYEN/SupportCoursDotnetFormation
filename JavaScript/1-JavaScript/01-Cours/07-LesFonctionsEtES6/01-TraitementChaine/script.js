/**
 * Le Traitement des chaînes
 */

// Déclaration de variable
var chaine = "Bonjour, comment allez-vous?";
var arrayChaine = chaine.split(' ').reverse();
var nomComplet = "DI pErSio aNThoNY"; 

/**
 * Split()
 */

console.table(chaine.split(''));
console.table(chaine.split(' '));
console.table(chaine.split(','));

/**
 * Reverse()
 */
console.table(chaine.split(' ').reverse());

/**
 * Join()
 */

console.table(arrayChaine.join('-'));
console.table(arrayChaine.join(' '));
console.table(arrayChaine.join(''));

/**
 * UPPER / LOWER CASE
 */

console.log(nomComplet.toLowerCase());
console.log(nomComplet.toUpperCase());

/**
 * LENGTH => Longueur de la chaîne
 */

console.log(nomComplet.length);
console.log(nomComplet[0].toLowerCase());
console.log(nomComplet[16]);

/**
 * IndexOf() => Retourne l'index d'un élément
 */

console.log(nomComplet.indexOf(' '));
console.log(nomComplet.lastIndexOf(' '));
console.log(nomComplet.indexOf('pEr'));
console.log(nomComplet.lastIndexOf('pEr'));


/**
 * Slice() => Extraire des bouts de chaîne
 */

if(nomComplet.indexOf('pEr') > -1){
    console.log(nomComplet.slice(nomComplet.indexOf(' '),nomComplet.lastIndexOf(' ')));
}

/**
 * Replace() => Remplace des valeurs d'une chaine
 */

console.log(nomComplet.replace('pEr','Per'));


/**
 * charAt() => retourne le caractere à un index
 */
console.log(nomComplet.charAt(0));

/**
 * Exercice => Mettre en forme la variable nomComplet
 */

// DI pErSio aNThoNY => Di Persio Anthony

console.log(nomComplet);
nomComplet = nomComplet.toLowerCase();
console.log(nomComplet);
nomComplet = nomComplet[0].toUpperCase() + nomComplet.slice(1);
console.log(nomComplet);
nomComplet =nomComplet.slice(0 , nomComplet.indexOf(' ') +1 ) + nomComplet[nomComplet.indexOf(' ') + 1].toUpperCase() + nomComplet.slice(nomComplet.indexOf(' ') + 2);
console.log(nomComplet);
nomComplet =nomComplet.slice(0 , nomComplet.lastIndexOf(' ') +1 ) + nomComplet[nomComplet.lastIndexOf(' ') + 1].toUpperCase() + nomComplet.slice(nomComplet.lastIndexOf(' ') + 2);
console.log(nomComplet);
