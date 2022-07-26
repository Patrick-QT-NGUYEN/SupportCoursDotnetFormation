-- Utilisation de Convert pour convertir un INt en VARCHAR
-- Syntaxe CONVERT(VARCHAR, <IntValue>)
-- Possibilité de concaténer avec l'opérateur +
-- Si création de colonne , utilisation du mot clé 'AS'

SELECT * FROM Employee As EMP

SELECT EMP.FIRST_NAME,
		EMP.LAST_NAME,
		EMP.DEPT_ID,
		'EMP'+ CONVERT(VARCHAR,EMP.DEPT_ID) AS EMP_DEPT_ID
FROM Employee As EMP

