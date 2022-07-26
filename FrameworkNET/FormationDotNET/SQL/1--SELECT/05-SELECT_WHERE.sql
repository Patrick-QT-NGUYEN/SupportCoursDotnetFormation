-- Requete pour voir la table
SELECT * FROM Product

-- Requête sur la table PRODUCT pour trouver un certain type de produit 'LOAN'
SELECT Pro.PRODUCT_CD ,
		Pro.DATE_OFFERED,
		Pro.DATE_RETIRED,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD 
FROM Product AS Pro
WHERE Pro.PRODUCT_TYPE_CD = 'LOAN'

-- Requête sur la table PRODUCT pour trouver un certain type de produit 'ACCOUNT'
SELECT Pro.PRODUCT_CD ,
		Pro.DATE_OFFERED,
		Pro.DATE_RETIRED,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD 
FROM Product AS Pro
WHERE Pro.PRODUCT_TYPE_CD = 'ACCOUNT'

-- Requête sur la table PRODUCT pour trouver un certain type de produit par le champ NAME
SELECT Pro.PRODUCT_CD ,
		Pro.DATE_OFFERED,
		Pro.DATE_RETIRED,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD 
FROM Product AS Pro
WHERE Pro.Name = 'Auto loan'