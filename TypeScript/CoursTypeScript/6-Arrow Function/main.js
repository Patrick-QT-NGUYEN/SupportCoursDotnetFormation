// 1ere déclaration
function Affichage(message) {
    return "Fonction = " + message;
}
var message = Affichage("hello world");
console.log(message);
// 2eme déclaration
var Affichage2 = function (message) {
    return 'Fonction 2 ' + message;
};
var message2 = Affichage2("Hello world");
console.log(message2);
// 3eme déclaration Arrow function
var Affichage3 = function (message) {
    return 'Fonction Arrow' + message;
};
var message3 = Affichage3("hello world");
console.log(message3);
var Addition = function (a, b) {
    var addition = a + b;
    return addition.toString();
};
console.log(Addition(4, 5));
var Addition2 = function () { return "Addition"; };
console.log(Addition2());
