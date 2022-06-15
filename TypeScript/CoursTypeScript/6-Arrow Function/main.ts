// 1ere déclaration
function Affichage(message:string):string
{
    return "Fonction = " +message;
}
let message=Affichage("hello world");
console.log(message);

// 2eme déclaration

let Affichage2=function (message:string):string{
    return 'Fonction 2 '+message;
}
let message2=Affichage2("Hello world");
console.log(message2);
// 3eme déclaration Arrow function

let Affichage3=(message:string):string=>{
    return 'Fonction Arrow' + message;
}
let message3=Affichage3("hello world");
console.log(message3);

let Addition=(a:number,b:number):string=>
{
    let addition = a+b;
    return addition.toString();
}
console.log(Addition(4,5));

let Addition2=():string=>"Addition";
console.log(Addition2());



