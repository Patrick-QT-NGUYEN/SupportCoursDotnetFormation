/**
 * Arrow and Classic Function()
 */

// Création des constantes
const link = document.querySelector('#link');
const result = document.querySelector('#result');

//Propagantion d'un Event Click
link.addEventListener('click', (event)=>{
    alert(`Arrow Function() : this => ${this} and event source is : ${event} `); // this = Window
})

//Propagantion d'un Event Click
link.addEventListener('click', function () {
    console.log(`Classic Function() : this => ${this}`)  // Button
})


// Appel de fonction depuis l'event click du button
function clickFunction(){
    result.innerHTML += "<h2>C'est cliqué !</h2>";
}

function clickAlert(){
    alert("Je m'affiche dans une alerte.");
}

function clickConfirm(){
   let response = confirm("Etes-vous sur?");
    result.innerHTML += response === true ? "<h2>C'est confirmé !</h2>"  :
    "<h2>Ce n'est pas confirmé !</h2>";
}