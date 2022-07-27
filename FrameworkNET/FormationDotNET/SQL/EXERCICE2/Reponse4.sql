-- Selectionner les 10 livres les plus ancien par Date de publication trié par ordre croissant
SELECT TOP 10 *
FROM livre
ORDER BY date_publication ASC