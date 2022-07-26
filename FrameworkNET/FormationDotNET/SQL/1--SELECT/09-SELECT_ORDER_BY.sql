-- Requete permettant de connaitre les employé avec une date d'embauche comprise dans un certain interval par ordre croissant
SELECT EMP.EMP_ID,
		EMP.FIRST_NAME,
		EMP.LAST_NAME,
		EMP.START_DATE,
		CONVERT(VARCHAR, EMP.START_DATE, 106) AS START_DATE_CONVERT
FROM Employee EMP
WHERE EMP.START_DATE
BETWEEN CONVERT(datetime,'01 MAY 2002',106)
AND CONVERT(datetime,'30-09-2002',105)
ORDER BY START_DATE ASC -- Comportement par défaut

-- Requete permettant de connaitre les employé avec une date d'embauche comprise dans un certain interval par ordre Décroissant
SELECT EMP.EMP_ID,
		EMP.FIRST_NAME,
		EMP.LAST_NAME,
		EMP.START_DATE,
		CONVERT(VARCHAR, EMP.START_DATE, 106) AS START_DATE_CONVERT
FROM Employee EMP
WHERE EMP.START_DATE
BETWEEN CONVERT(datetime,'01 MAY 2002',106)
AND CONVERT(datetime,'30-09-2002',105)
ORDER BY START_DATE DESC

-- Requete Pour trier par Product_Type en ordre croissant
-- Puis par Nom en ordre décroissant
SELECT Pro.Product_CD,
		Pro.PRODUCT_TYPE_CD,
		Pro.NAME
From Product AS Pro
ORDER BY Pro.PRODUCT_TYPE_CD ASC,
			Pro.NAME DESC