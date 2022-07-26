-- La condition Having nous permet d'indiquer des condition de séléction pour filtrer des groupes de résultats
-- Ma commande WHERE met en oeuvre des condition sur les colonnes séléctionnées, alors que la commande HAVING met en oeuvre
-- des conditions sur les groupes qui sont crées par l'opérateur GROUP_BY

-- Requête pour regrouper les catégorie de service et n'avoir que les membre ayant plus de 3 entrées
-- Sans la condition Having
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) As Count_Compte,
		Sum(Acc.AVAIL_BALANCE) As Sum_Montant,
		Avg(Acc.AVAIL_BALANCE) As Moyenne_Montant
From Account Acc
Group By Acc.PRODUCT_CD

-- Avec la condition HAVING
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) As Count_Compte,
		Sum(Acc.AVAIL_BALANCE) As Sum_Montant,
		Avg(Acc.AVAIL_BALANCE) As Moyenne_Montant
From Account Acc
Group By Acc.PRODUCT_CD
Having Count(Acc.Product_CD) > 3


-- La distinction entre WHERE et HAVING
--		WHERE est utilisé pour filtrer la BDD avant le regroupement par GROUP BY
--		HAVING est utilisé pour filtrer la BDD après le regroupement par GROUP BY

-- Requête pour obtenir des informations d'une sucursale en particulier (OPEN_Branch_Id)
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.OPEN_BRANCH_ID,
		Acc.AVAIL_BALANCE
From Account Acc
-- Utilisation du WHERE pour filtrer les données avant le GROUP BY
WHERE Acc.OPEN_BRANCH_ID = 1

-- Affichage des élements des la sucursale 1 avec regroupement par Product_Cd contenant au moins un e entree dans la table Account
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) As Count_Compte,
		Sum(Acc.AVAIL_BALANCE) As Sum_Montant,
		Avg(Acc.AVAIL_BALANCE) As Moyenne_Montant
From Account Acc
-- Utilisation du WHERE AVANT le Group BY
WHERE Acc.OPEN_BRANCH_ID = 1
Group By Acc.PRODUCT_CD
-- Utilisation de HAVING pour filtrer APRES le GROUP BY
Having Count(Acc.Product_CD) > 1