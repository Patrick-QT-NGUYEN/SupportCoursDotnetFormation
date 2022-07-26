-- La Commande FULL OUTER JOIN est la combinaison des commandes LEFT et RIGHT OUTER JOIN

----Syntaxe
--SELECT Colonnes
--FROM table1
--FULL (OUTER) JOIN table2
--On Table1.Colonne = Table2.Colonne

-- Affichage de la table Customer
SELECT * FROM CUSTOMER

-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- CUSTOMER FULL OUTER JOIN OFFICER
SELECT Cus.CUST_ID,
		Cus.CITY,
		Cus.STATE,
		Ofc.CUST_ID As Ofc_Cust_Id,
		Ofc.OFFICER_ID,
		Convert(VARCHAR, Ofc.Start_Date, 105) Start_Date_Convert,
		Ofc.TITLE
FROM Customer Cus -- Table 1
FULL OUTER JOIN OFFICER Ofc -- Table 2
ON Cus.CUST_ID = Ofc.CUST_ID