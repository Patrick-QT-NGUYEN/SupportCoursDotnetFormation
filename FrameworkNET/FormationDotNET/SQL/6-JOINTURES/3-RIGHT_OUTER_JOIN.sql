-- Le mote Clé RIGHT OUTER JOIN est une jointure externe pour récupérer les informations de la table de gauche (Table 2) 
-- tout en récupérant les données associées avec la table de droite (Table 1)

-- Affichage de la table Customer
SELECT * FROM CUSTOMER

-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- OFFICER RIGHT OUTER JOIN CUSTOMER
SELECT Ofc.CUST_ID As Ofc_Cust_Id,
		Ofc.OFFICER_ID,
		Ofc.START_DATE,
		Ofc.TITLE,
		Cus.CUST_ID,
		Cus.FED_ID,
		Cus.STATE
FROM OFFICER Ofc -- table 1
RIGHT OUTER JOIN CUSTOMER Cus -- Table 2
ON Ofc.CUST_ID = Cus.CUST_ID

