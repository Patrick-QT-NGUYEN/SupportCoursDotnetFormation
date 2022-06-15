// En ES5
// const success = (message, data)=>{
//     return{
//         message : message,
//         data : data
//     }
// }


// exports.success;

// En ES6

exports.success = (message, data)=>{
    return{message ,data}
}

exports.getUniqueId = (coursList) =>{
    // Itération des element de coursliste et extrair la clé id de chaque objet
    const coursIds = coursList.map(cours => cours.id);
    // Isoler le plus grande valeur de Id dans la const maxId
    const maxId = coursIds.reduce((acc,b)=>Math.max(acc,b));
    // Ajout de + 1 à la plus grande valeur
    const UniqueId = maxId + 1;
    // Retourne cette valeur
    return UniqueId;
}