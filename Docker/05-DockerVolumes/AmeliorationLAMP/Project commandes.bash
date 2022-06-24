## Project Volumes

## Désarchivez le fichier zip et buildez votre image
$ docker build -t my_lamp .

## créez un nouveau volume
$ docker volume create --name mysqldata

## Pour les sources de mon application, je vais faire les choses différemment. 
##Je vais juste changer le dossier source du volume ( les volumes nous donne cette possibilité).
## Lançons donc notre conteneur :
$ docker run -d --name my_lamp_c -v $PWD/app:/var/www/html -v mysqldata:/var/lib/mysql -p 8080:80 my_lamp

## Créer des articles
Depuis le front php

## Stopper le conteneur
$ docker stop my_lamp_c

## supprimmer le conteneur
$ docker rm -f my_lamp_c

## Relançons donc notre conteneur :
$ docker run -d --name my_lamp_c -v $PWD/app:/var/www/html -v mysqldata:/var/lib/mysql -p 8080:80 my_lamp

## Les articles sont toujours présent
