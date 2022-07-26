DROP TABLE [Utilisateur]


/*
    Création Table Utilisateur
*/
CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Prenom] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Telephone] VARCHAR(17) NOT NULL,
)

/*
    INSERT UTILISATEUR
*/
INSERT INTO [dbo].[Utilisateur] ( [Nom], [Prenom], [Email], [Telephone]) 
VALUES ( N'Toto', N'Titi', N'toto@gmail.com', N'+33 6 41 52 63 98'),
		 ( N'Di Persio', N'Anthony', N'anthony@utopios.net', N'+33 6 41 74 85 21')