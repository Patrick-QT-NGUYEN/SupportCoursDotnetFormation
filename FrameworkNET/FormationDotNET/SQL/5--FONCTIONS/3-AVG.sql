-- La fonction AVG() permet de calculer une valeur moyenne sur un ensemble de données
select * from ACCOUNT

-- Calculer le montant moyen pour les comptes épargne (SAV)
SELECT Avg(Acc.AVAIL_BALANCE) As MoyenneEpargne
From ACCOUNT Acc
Where Acc.PRODUCT_CD = 'SAV'

-- En utilisant le GroupBy
-- Un client possède un ou plusieurs comptes
-- Calcul la moyenne des comptes pour chaque client de la Succurssale ( Branch_Id = 1)
SELECT Acc.CUST_ID,
		Avg(Acc.AVAIL_BALANCE) As MoyenneComptes
From ACCOUNT Acc
Where Acc.OPEN_BRANCH_ID = 1
Group By Acc.CUST_ID