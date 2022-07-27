
DROP TABLE PERSONNE


/*
 * CREATION TABLE PERSONNE
 */
CREATE TABLE PERSONNE
(
	ID INT IDENTITY(1,1) NOT NULL ,
	TITRE VARCHAR(5) NOT NULL,
	NOM VARCHAR(50) NOT NULL,
	PRENOM VARCHAR(50) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	TELEPHONE VARCHAR(17) NOT NULL,
	PRIMARY KEY CLUSTERED (Id ASC)
)

/*
 * INSERTION VALEUR
 */

INSERT INTO PERSONNE (titre,prenom,nom,email,telephone)
VALUES (N'Mlle', N'Tata', N'Toto', N'tatatoto@monemail.fr', N'0987654321'),
		(N'Mr', N'Minet', N'Gros', N'grosminet@monemail.net', N'0612345678'),
		(N'Mme', N'Jane', N'Doe', N'janedoe@gmail.com', N'0987654321'),
		(N'Mr', N'Bernard', N'Minet', N'bernardminet@monemail.net', N'0614762345'),
		(N'Mlle', N'Jessica', N'Rabbit', N'jr@gmail.com', N'0677777777'),
		(N'Mr', N'Zorro', N'Legrand', N'zoro@monemail.com', N'0987654321'),
		(N'Mme', N'Foo', N'Bar', N'foo@bar.com', N'0913243546')
