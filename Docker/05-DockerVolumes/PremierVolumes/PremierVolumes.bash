## Création d'un Volume
$ docker volume create volume-test

## Lister tout les volumes
$ docker volume ls

## Inspecter un volume
$ docker volume inspect volume-test

## Cette commande retourne
[
    {
        "CreatedAt": "2019-07-03T10:03:20+02:00",
        "Driver": "local",
        "Labels": {},
        "Mountpoint": "/var/lib/docker/volumes/volume-test/_data",
        "Name": "volume-test",
        "Options": {},
        "Scope": "local"
    }
]

## Supprimer un volume
$ docker volume rm volume-test

## Créer le dockerfile pour une nouvelle image
FROM alpine:latest

RUN mkdir /data

WORKDIR /data

## Build de l'image
$ docker build -t vtest .

## la commande suivante va créer et monter le volume data-test dans le dossier /data du conteneur
$ docker run -ti --name vtest_c -v data-test:/data vtest

## Ouvrez un autre terminal et dans celui-ci inspectez le nouveau volume
$ docker volume inspect data-test

## Cette commande retourne
[
    {
        "CreatedAt": "2019-07-03T10:28:55+02:00",
        "Driver": "local",
        "Labels": null,
        "Mountpoint": "/var/lib/docker/volumes/data-test/_data",
        "Name": "data-test",
        "Options": null,
        "Scope": "local"
    }
]

## Pour le moment le dossier est vide, maintenant retournez vers le terminal avec le shell 
## du conteneur et créez dans le dossier /data un fichier avec le texte suivant
$ echo "ceci est un test" > test.txt

## Affichage du fichier
$ cat test.txt

## Sortir du conteneur
$ exit

## Supprimer le conteneur
$ docker rm -f vtest_c

## Création d'une nouvelle instance
$ docker run -ti --name vtest_c -v data-test:/data vtest

## Affichage du fichier
$ cat test.txt