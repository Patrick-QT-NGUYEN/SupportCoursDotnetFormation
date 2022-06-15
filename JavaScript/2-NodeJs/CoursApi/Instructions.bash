## 1-Création d'un fichier app.js et mettre les instruction
console.log("Hello from NodeJs");

## 2-Executer le fichier App.js dans la console saisir
$ node app.js

## 3-Initialiser le fichier package.json et les nodes modules
$ npm init

# 4-Remplacer le script "test" par "start"
"scripts": {
    "start": "node app.js"
},

# 5-Executer la commande
$ npm run start

## 6-Installation de Express
$ npm install express --save

# 7-Modifier le fichier app.js
const express = require('express');

const app = express();
const port = 3000;

app.get('/',(req,res)=> res.send("Hello from NodeJs!"));

app.listen(port, ()=>console.log(`L application node est demarée sur : http://localhost:${port}`));

# 8-Executer la commande et ouvrir le navigateur
$ npm run start

# 9-Installation de nodemon (permet de ne pas avoir a redemarrer le server apres les modifications)
$ npm install nodemon --save-dev # --save-dev => voir dans le fichier package.json

# 10-Modifier le script "start"
"scripts": {
    "start": "node app.js",
    "dev": "nodemon app.js"
},

# 11-Executer la commande et ouvrir le navigateur (modifier le fichier app.js, sauvegarder puis rafraichir le navigateur)
$ npm run dev

# 12-Création d'un end point pour notre api, rajouter (dans app.js)
app.get('/api/cours/1',(req,res)=> res.send("Welcome to JS cours!")); # ctrl + s puis rafraichier le navigateur

# 13-Visiter la route 
http://localhost:3000/api/cours/1 # retourne Welcome to JS cours!

# 14-Recupération des params de route pour l'id (modification de notre route précedente V1 => V2)
app.get('/api/cours/:id',(req,res)=> {
    const id = req.params.id; # Permet de recupérer le parametre id
    res.send(`Welcome to cours ${id}!`);
});

# 15-Il est possible de recupération des params de route pour l'id et de nom (V3)
app.get('/api/cours/:id/:name',(req,res)=> {
    const id = req.params.id; # Permet de recupérer le parametre id
    const name = req.params.name; # Permet de recupérer le parametre name
    res.send(`Welcome to cours N°${id} : ${name}`);
});

# 16-EXERCICES => Mettre en place une route /api/cours qui retournera le nombre de formations contenues dans la liste CoursList
app.get('/api/cours', (req, res) => res.send(`Il y a ${coursList.length} cours dans notre catalogue de formation`))

# 17-EXERCICES => Modifier le EndPoint /api/cours/:id afin de retourner la formation ayant cet ID.
app.get('/api/cours/:id', (req, res) => {
    const id = parseInt(req.params.id);    
        const cours = coursList.find(cours => cours.id === id);
        console.log(cours);
        cours != null? res.send(cours):res.send("Cette formation n'existe pas!");   
})

# 18-Revenir sur la V4 et modifier pour retourner du JSON (res.json())
app.get('/api/cours/:id',(req,res)=> {
    const id = parseint(req.params.id);     
    const cours = coursList.find(x => x.id === id);                                                             // V5
    res.json(cours);
});


# 19-Installer JSON Viewer pour chrome afin d'optimiser l'affichage JSON dans le navigateur puis refaire la requete /api/cours/1
https://chrome.google.com/webstore/detail/json-viewer/gbmdgpbipfallnflgajpaliibnhdgobh


# 20-Ajout du status de la requete dans la response
1-Création du fichier helpers.js ( demo 2 syntaxes )
    
    # En ES 5 
    const succes = (message, data) =>{
        return{
            message:message,
            data:data
        }
    }

    exports.succes;

    # En ES6
    exports.success = (message, data) =>{
        return{message,data}
    }

2-Création dans App.js :
    const success = require('./helper.js'); // # Au début du fichier
    const message = "Un cours a été trouvé"; //# dans Api cours list V5

# 21-Exercice =>Modifier le end point /api/cours afin qu'il retourne la liste des formations au format JSON
app.get('/api/cours', (req, res) => {
    const message = `Il y a ${coursList.length} cours dans notre catalogue de formation`;
    res.json(success(message, coursList));
});

# 22-Création d'un middleware (Logger) permettant de faires des log dans la console
const logger = (req,res,next)=>{
    console.log(`URL : ${req.url}`);
    next();
}
app.use(logger);
## Simplifiable en
app.use((req,res,next)=>{
    console.log(`URL : ${req.url}`);
    next();
});

# 23-Installation d'un middleware deja existant => Morgan (log dans la console)
$ npm install morgan --save-dev
# puis ajouter dans app.js
const morgan = require('morgan');
app.use(morgan('dev'));

# 24-Installation d'un middleware deja existant => serve-favicon (pour retourner un favicon)
$ npm install serve-favicon --save
# Puis ajouter dans app.js
const favicon = require('serve-favicon');
app
 .use(favicon(__dirname+'/favicon.ico')) # l'ordre des middleware est important
 .use(morgan('dev'));

###
# POST
###
# 25-Création du END POINT pour poster un nouveau cours
app.post('/api/cours',(req,res)=>{
    const id = coursList.length+1;
    const coursCreated = {...req.body,...{id:id, created : new Date()}};
    coursList.push(coursCreated);
    const message = `Le cours ${coursCreated.name} a bien été ajouté`;
    res.json(success(message, coursCreated));
})
# 26-Import de body parser pour parser en JSON L'ensemble des requêtes
$  npm install body-parser --save

# 27-Import du middelware body pardser et réessayer dans postman pour le post
const bodyParser = require('body-parser');
# Ajout du middleware
app
    .use(favicon(__dirname+'/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());

# 28- Utilisation de la méthode getUniqueId
###
# PUT => UPDATE
###
app.put('/api/cours/:id', (req, res) => {
    const id = parseInt(req.params.id);
    const coursUpdated = { ...req.body,...{ id: id, updated: new Date() } }
    coursList = coursList.map(cours=>{
        return cours.id === id ? coursUpdated : cours
    })
    const message = `Le cours ${coursUpdated.name} a été modifié`;
    res.json(success(message, coursUpdated));
})

###
# DELETE =>
###
app.delete('/api/cours/:id', (req,res)=>{
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === id);
    coursList = coursList.filter(cours => cours.id !== id);
    const message = `Le cours ${coursDeleted.name} a été supprimé.`;
    res.json(success(message, coursDeleted));
})

###
# PERSISTANCE DES DONNEES EN JSON
###
# Création de la liste de formation en json (savelist.json)
[
    {
        "category": "Reférencement",
        "name": "SEO Premium",
        "difficulte": 3,
        "price": 249,
        "id": 1,
        "created": "2019-06-16T16:54:46.308Z"
    },
    {
        "category": "Langage de programmation",
        "name": "C#",
        "difficulte": 4,
        "price": 299,
        "id": 2,
        "created": "2019-06-16T16:54:56.308Z"
    },
    {
        "category": "Langage de programmation",
        "name": "JavaScript",
        "difficulte": 3,
        "price": 199,
        "id": 3,
        "created": "2019-06-16T16:55:06.308Z"
    },
    {
        "category": "Langage de programmation",
        "name": "HTML/CSS",
        "difficulte": 2,
        "price": 149,
        "id": 4,
        "created": "2019-06-16T16:55:16.308Z"
    },
    {
        "category": "FrameWork",
        "name": "React",
        "difficulte": 3,
        "price": 299,
        "id": 5,
        "created": "2019-06-16T16:55:26.308Z"
    },
    {
        "category": "FrameWork",
        "name": "Vue.Js",
        "difficulte": 2,
        "price": 299,
        "id": 6,
        "created": "2019-06-16T16:55:36.308Z"
    },
    {
        "category": "FrameWork",
        "name": "Angular",
        "difficulte": 4,
        "price": 299,
        "id": 7,
        "created": "2019-06-16T16:55:46.308Z"
    },
    {
        "category": "Outils collaboratifs",
        "name": "Git",
        "difficulte": 3,
        "price": 199,
        "id": 8,
        "created": "2019-06-16T16:55:56.308Z"
    },
    {
        "category": "FrameWork",
        "name": "Sass",
        "difficulte": 3,
        "price": 149,
        "id": 9,
        "created": "2019-06-16T16:56:06.308Z"
    },
    {
        "category": "Langage de programmation",
        "name": "C++",
        "difficulte": 4,
        "price": 299,
        "id": 10,
        "created": "2022-06-10T10:10:18.531Z"
    }
]

### Création de la méthode saveList()
function SaveList(){
    const objectToJson = JSON.stringify(coursList);
    writeFileSync('./data/savedList.json',objectToJson);
    console.log("Données Sauvegardées...");
}   

###Modification des END POINT
// POST #28
app.post('/api/cours', (req, res) => {
    const id = getUniqueId(coursList);
    const coursCreated = { ...req.body, ...{ id: id, created: new Date() } };
    coursList.push(coursCreated);
    SaveList(); ## Modif ici
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
    SaveList();## Modif ici
    const message = `Le cours ${coursUpdated.name} a été modifié`;
    res.json(success(message, coursUpdated));
})

// DELETE
app.delete('/api/cours/:id', (req,res)=>{
    const id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === id);
    coursList = coursList.filter(cours => cours.id !== id);
    SaveList();## Modif ici
    const message = `Le cours ${coursDeleted.name} a été supprimé.`;
    res.json(success(message, coursDeleted));
})

###
#   Cors #29
###

## Installer le package
$ npm install cors --save

## imort 
const cors = require('cors');

## Injection du service Cors
app
    .use(cors())
    .use(favicon(__dirname + '/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());

