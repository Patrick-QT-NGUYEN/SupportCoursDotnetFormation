-- La fonction Max() permet de retourner la plus petite valeur d'une colonne
select * from Account

-- Selection de la valeur maximale du la table Account
SELECT Max(Acc.AVAIL_BALANCE) As SoldeMax
From Account ACC

-- Selection de la valeur maximale des compte épargne
SELECT Max(Acc.AVAIL_BALANCE) As SoldeMax
From Account ACC
WHERE Acc.PRODUCT_CD='SAV'

-- En utilisant le Group By
-- Les comptes peuvent être dans différentes agences
-- Rechercher la valeur maximale d'un compte pour chaque agence
SELECT Acc.OPEN_BRANCH_ID,
		Max(Acc.AVAIL_BALANCE) As SoldeMax
FROM ACCOUNT Acc
Group By Acc.OPEN_BRANCH_ID