const express = require('express');
const morgan = require('morgan');
const cors = require('cors'); // #29
const bodyParser = require('body-parser');
const favicon = require('serve-favicon');


//let coursList = require('./data/CoursList'); //# JSON
const {readFileSync, writeFileSync} = require('fs');
let coursList = JSON.parse(readFileSync('./data/savedList.json','utf-8'));
const { success , getUniqueId } = require('./helper.js');

//console.table(coursList);

// Instaciation de Express
const app = express();
// Définition du port de communication
const port = 7777;

// Déclaration d'un middleware pour logger dans la console des requetes
const logger = (req, res, next) => {
    console.log(`URL : ${req.url}`);
    next();
}

app
    .use(cors())// #29
    .use(favicon(__dirname + '/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());

function SaveList(){
    const objectToJson = JSON.stringify(coursList);
    writeFileSync('./data/savedList.json',objectToJson);
    console.log("Données Sauvegardées...");
}   

// End Point pour notre Api
app.get('/', (req, res) => res.send("Hello from NodeJs Avec MAJ"));

// // Exercice #16
// app.get('/api/cours', (req, res) => res.send(`Il y a ${coursList.length} cours dans notre catalogue de formation`));

// Exercice #21
app.get('/api/cours', (req, res) => {
    const message = `Il y a ${coursList.length} cours dans notre catalogue de formation`;
    res.json(success(message, coursList));
});

// app.get('/api/cours/1', (req, res) => res.send(`Welcome to NodeJs Cours N°${id}`)})  //V1

// app.get('/api/cours/:id', (req, res) => {
//     const id = parseInt(req.params.id);
//     console.log(id);                                                                //V2 #14
//     res.send(`Welcome to NodeJs Cours N°${id}`);
// })

// app.get('/api/cours/:id', (req, res) => {
//     const id = parseInt(req.params.id);    
//         const cours = coursList.find(cours => cours.id === id);
//         console.log(cours);                                                             //V3
//         cours != null? res.json(cours):res.send("Cette formation n'existe pas!");   
// })

app.get('/api/cours/:id', (req, res) => {
    const id = parseInt(req.params.id);
    const cours = coursList.find(cours => cours.id === id);
    const message = "Un cours a été trouvé";
    // if (cours != null) {
    //     res.json(success(message,cours));
    // } 
    // else {
    //     res.send("Cette formation n'existe pas!")
    // };
    cours != null ?
        res.json(success(message, cours))
        :
        res.send("Cette formation n'existe pas!");
})

app.get('/api/cours/:id/:name', (req, res) => {
    const id = parseInt(req.params.id);
    const cours = req.params.name;
    console.log(cours);                                                                  //V3
    res.send(`Welcome to Cours N°${id} => ${cours}`);
})
// // POST #25
// app.post('/api/cours', (req, res) => {
//     const id = coursList.length + 1;
//     const coursCreated = { ...req.body, ...{ id: id, created: new Date() } };
//     coursList.push(coursCreated);
//     const message = `Le cours ${coursCreated.name} a bien été ajouté`;
//     res.json(success(message, coursCreated));
// })

// POST #28
app.post('/api/cours', (req, res) => {
    const id = getUniqueId(coursList);
    const coursCreated = { ...req.body, ...{ id: id, created: new Date() } };
    coursList.push(coursCreated);
    SaveList();
    const message = `Le cours ${coursCreated.name} a bien été ajouté`;
    res.json(success(message, coursCreated));
})

// PUT 
app.put('/api/cours/:id', (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = { ...req.body,...{ id: id, updated: new Date() } }
    coursList = coursList.map(cours=>{
        return cours.id === id ? coursUpdated : cours;
    })
    SaveList();
    const message = `Le cours ${coursUpdated.name} a été modifié`;
    res.json(success(message, coursUpdated));
})

// DELETE
app.delete('/api/cours/:id', (req,res)=>{
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === id);
    coursList = coursList.filter(cours => cours.id !== id);
    SaveList();
    const message = `Le cours ${coursDeleted.name} a été supprimé.`;
    res.json(success(message, coursDeleted));
})

app.listen(port, () => console.log(`L'application est démarée sur : http://localhost:${port}`));


//console.log("Hello from NodeJs");