-- Le mot-clé LEFT OUTER JOIN est une jointure externe pour récupérer toutes les informations de la table de gauche (table 1) tout en récupérant les données
-- associés avec la table de droite (Table 2)
-- S'il y a pas de correspondance les colonnes de la table de droite (Table 2) vaudront toutes Null.

-- Affichage de la table Customer
SELECT * FROM CUSTOMER

-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- CUSTOMER LEFT OUTER JOIN OFFICER
-- LEFT OUTER JOIN peut être remplacé par LEFT JOIN (Même résultat)
SELECT Cus.CUST_ID,
		Cus.STATE,
		Cus.ADDRESS,
		Cus.CITY,
		Cus.POSTAL_CODE,
		Ofc.OFFICER_ID,
		Ofc.FIRST_NAME,
		Ofc.LAST_NAME,
		Ofc.START_DATE,
		OFc.TITLE
FROM CUSTOMER Cus -- Table 1
LEFT JOIN OFFICER Ofc -- Table 2
ON Cus.CUST_ID = Ofc.CUST_ID