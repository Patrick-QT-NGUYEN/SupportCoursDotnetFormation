## Import de React
<!-- Liens vers les ressources ext -->
    <script crossorigin src="https://unpkg.com/react@16/umd/react.development.js"></script>
    <script crossorigin src="https://unpkg.com/react-dom@16/umd/react-dom.development.js"></script>
    
## Import de Babel
<script src="https://unpkg.com/babel-standalone@6/babel.min.js"></script>
<script src="./app.js" type="text/babel"></script>

## Création d'un élément du DOM permettant le rendu des composant React (index.html)
<div id="app"></div>

## Création d'un composant (dans app.js)
function MyFirstComponent() {
    return (
        <h2>Bonjour, {nom}</h2>
    )
}

## Ajout de la méthode de rendu ReactDOM (dans app.js)
ReactDOM.render(
    elementReact,
    document.getElementById('app')
);