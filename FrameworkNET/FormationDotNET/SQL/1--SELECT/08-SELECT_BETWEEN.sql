
SELECT * FROM Employee

-- Requete pour retourner les employé dont l'id est compris entre 5 et 10
SELECT * FROM Employee
WHERE EMP_ID BETWEEN 5 AND 10

-- Equivalent
SELECT * FROM Employee
WHERE EMP_ID >=5 
AND EMP_ID <=10 

-- Requete permettant de connaitre les employé avec une date d'embauche comprise dans un certain interval
SELECT EMP.EMP_ID,
		EMP.FIRST_NAME,
		EMP.LAST_NAME,
		EMP.START_DATE,
		CONVERT(VARCHAR, EMP.START_DATE, 106) AS START_DATE_CONVERT
FROM Employee EMP
WHERE EMP.START_DATE
BETWEEN CONVERT(datetime,'01 MAY 2002',106)
AND CONVERT(datetime,'30-09-2002',105)