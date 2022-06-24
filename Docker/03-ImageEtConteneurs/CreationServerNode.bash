################################### Server Node.js #################################################

# Création d'un conteneur docker basé sur une image linux debian et redirigeant le port 8080 de l'hote vers le port 80 du conteneur 
$ docker run -it --name=container_web_server -p 8080:80 debian:latest bash

# Mise à jour du conteneur
$ apt update && apt upgrade -y

# Installation de node.js, NPM, nano
$ apt install nodejs -y && apt install npm -y && apt install nano -y 

# Création du fichier index.js
$ nano index.js

# Copier les instructions suivantes
const express = require('express')
const http = require ('http')
const app = express()

app.get('/', (req,res)=> {
    res.end("Bonjour depuis mon serveur node.js...")
    http.request('http://'+process.env.ADRESS_APACHE4)
})

app.listen(80,()=> {
    console.log("app is running")
})

# initialisation d'un projet npm
$ npm init

# installation de express
$ npm install express

# execution du fichier 
$ node index.js