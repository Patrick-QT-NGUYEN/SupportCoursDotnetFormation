## Créer les fichiers =>
index.html
main.js

## Ajouter dans le <body> de index.html
<!-- Rendu des element React Ici -->
    <div id="app"></div>

<!-- Liens vers les ressources ext -->
    <script src="./app.js" type="text/babel"></script>

## Initialiser un repos npm
$ npm init

## Instalation des package react et babel
$ npm install react --save
$ npm install react-dom --save
$ npm install --save-dev @babel/preset-react
$ npm install nodemon --save-dev

##Création du composant parent de toutsles composants react de notre application
App.js

## Contenu du fichier main.js
import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';


ReactDOM.render(
    <React.StrictMode>
        <App/>
    </React.StrictMode>,
    document.getElementById('root')
)

## Contenu du fichie App.js
