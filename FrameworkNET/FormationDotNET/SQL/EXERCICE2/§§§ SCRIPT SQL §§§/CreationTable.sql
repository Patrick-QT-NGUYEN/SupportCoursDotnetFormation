DROP TABLE livre;
/*
 * Création table livre
 */
CREATE TABLE [dbo].[livre]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
	[titre] VARCHAR(150) NOT NULL,
    [auteur] VARCHAR(50) NOT NULL,
    [editeur] VARCHAR(50) NOT NULL,
    [date_publication] DATE NOT NULL,     
    [isbn_10] VARCHAR(10) NOT NULL,
    [isbn_13] VARCHAR(15) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)