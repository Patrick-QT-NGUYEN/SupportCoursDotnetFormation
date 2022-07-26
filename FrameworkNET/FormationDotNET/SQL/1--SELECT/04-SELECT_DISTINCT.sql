-- Requete pour voir la table
--SELECT * FROM Product

-- Requete pour voir la table (avec tous les champs détaillés)
SELECT Pro.PRODUCT_CD ,
		Pro.DATE_OFFERED,
		Pro.DATE_RETIRED,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD
FROM Product AS Pro

-- Requete pour voir un champ de la table
SELECT Pro.PRODUCT_TYPE_CD
FROM Product AS Pro

--SELECT DISTINCT va nous permetre de retourner des valeurs uniques
SELECT DISTINCT Pro.PRODUCT_TYPE_CD
FROM Product AS Pro
