-- La fonction Sum() permet de calculer la somme totale d'une colonne contenant des valeurs numériques
select * from ACCOUNT
-- Calculer La somme des comptes d'un client (Cust_Id = 1)
SELECT Sum(Acc.AVAIL_BALANCE) As SommeComptes
From Account Acc
Where Acc.CUST_ID = 1

-- En utilisant le Group By
-- Calculer la somme des comptes des clients
SELECT Acc.CUST_ID,
		sum(Acc.AVAIL_BALANCE) AS SommeDesComptes
FROM ACCOUNT Acc
GROUP BY Acc.CUST_ID