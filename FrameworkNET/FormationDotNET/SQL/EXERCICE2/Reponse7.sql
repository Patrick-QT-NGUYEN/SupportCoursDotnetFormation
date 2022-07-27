-- Faire une modification du nom de l'auteur sur une entrée de la base
--SELECT * FROM livre
UPDATE livre
SET auteur = 'Agatha Christie'
WHERE auteur Like 'Agatha Christies'
