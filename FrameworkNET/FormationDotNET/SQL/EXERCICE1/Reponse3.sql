-- Trier les personnes (Mlle)
SELECT nom, prenom, email, telephone
FROM PERSONNE
WHERE TITRE = 'Mlle'

-- Trier les personnes (Mme)
SELECT nom, prenom, email, telephone
FROM PERSONNE
WHERE TITRE = 'Mme'

-- Trier les personnes (Mr)
SELECT nom, prenom, email, telephone
FROM PERSONNE
WHERE TITRE LIKE 'Mr'

-- Trier par titre
SELECT titre,nom, prenom, email, telephone
FROM PERSONNE
Order BY titre ASC