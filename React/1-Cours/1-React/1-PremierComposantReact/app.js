/**
 * 1- Création d'un ELEMENT React (JSX)
 */

const nom = "Anthony Di Persio";
const elementReact = <h2>Bonjour, {nom}</h2>;

/**
 * 2-Création d'un composant React
 */
function MyFirstComponent() {
    return (
        <h2>Bonjour, {nom}</h2>
    )
}

/**
 * 3-Création d'un composant React Avec Parametres
 */
function MySecondComponent({ nom, prenom }) {
    return (
        <h2>Bonjour, {nom} {prenom}</h2>
    )
}

/**
 * 4-Création d'un composant React Avec Parametres et fonction
 */
const user = {
    firsname: "Anthony",
    lastname: "Di Persio"
}

function formatName(user) {
    return `${user.firsname} ${user.lastname}`;
}


function MyThirdComponent({user}) {
    return (
        <h2>Bonjour, {formatName(user)}</h2>
    )
}


/**
 * 1-Rendu de l'elementReact
 */
ReactDOM.render(
    elementReact,
    document.getElementById('app')
);

/**
 * 2- Rendu Avec un Composant (sans params)
 */

// 1er composant sans params
// ReactDOM.render(
//     <React.Fragment>
//         <MyFirstComponent />
//         <MyFirstComponent />
//         <MyFirstComponent />
//     </React.Fragment>
//     // <>
//     //     <MyFirstComponent />
//     //     <MyFirstComponent />
//     //     <MyFirstComponent />
//     // </>
//     ,
//     document.getElementById('root')
// )

/**
 * 3- Rendu Avec un Composant avec Params
 */

// // 2nd Composant avec Params
// ReactDOM.render(
//     <MySecondComponent nom="Doe" prenom="John" />
//     ,
//     document.getElementById('root')
// )

/**
 * 4- Rendu Avec un Composant avec Params V2
 */

// 2nd Composant avec Params
ReactDOM.render(
    <MyThirdComponent user={user} />
    ,
    document.getElementById('root')
)