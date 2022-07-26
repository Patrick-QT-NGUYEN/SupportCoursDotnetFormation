-- D'abord, nous devons comprendre ce que sont les fonctions d'agrégation :
--    Sum: la fonction calcule la somme sur un ensemble d'enregistrements
--    Avg: la fonction calcule la moyenne sur un ensemble d'enregistrements
--    Count: la fonction compte le nombre d'enregistrement 
--    Min: la fonction récupère la valeur minumum
--    Max: la fonction récupère la valeur maximum
-- Ce sont les fonctions d'agrégation courantes. Tous ces fonctions prennent tout leur sens lorsqu'elles sont utilisées avec la commande Group by.

-- Requete table Account
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE
From Account Acc

-- La requête permet de voir la somme d'argent et la moyenne des comptes par rapport à la catégorie de services (Product_Cd)
-- Pour cela on les regroupe par Product_CD
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) As Count_Compte,
		Sum(Acc.AVAIL_BALANCE) As Sum_Montant,
		Avg(Acc.AVAIL_BALANCE) As Moyenne_Montant
From Account Acc
Group By Acc.PRODUCT_CD