-- La fonction Min() permet de retourner la plus petite valeur d'une colonne
select * from Account

-- Selection de la valeur minimale du la table Account
SELECT Min(Acc.AVAIL_BALANCE) As SoldeMin
From Account ACC

-- Selection de la valeur minimale des compte épargne
SELECT Min(Acc.AVAIL_BALANCE) As SoldeMin
From Account ACC
WHERE Acc.PRODUCT_CD='SAV'

-- En utilisant le Group By
-- Les comptes peuvent être dans différentes agences
-- Rechercher la valeur minimale d'un compte pour chaque agence
SELECT Acc.OPEN_BRANCH_ID,
		Min(Acc.AVAIL_BALANCE) As SoldeMin
FROM ACCOUNT Acc
Group By Acc.OPEN_BRANCH_ID