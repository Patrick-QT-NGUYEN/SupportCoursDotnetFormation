-- Requêtes pour tout les champs de la table Employee
SELECT * From EMPLOYEE

-- Requête de recherche des employés donc le prénom commence par S
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'

-- Requête de recherche des employés donc le prénom commence par S
-- Et travail dans le département Opération (1)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID =1

-- Requête de recherche des employés donc le prénom commence par S
-- Et travail dans le département Opération (1)
-- Et occupe le poste de caissier (Teller)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID =1
AND Emp.TITLE = 'Teller'

-- Requête de recherche des employés donc le prénom commence par S
-- Ou par J
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
OR Emp.FIRST_NAME LIKE 'J%'

-- Requête de recherche des employés donc le prénom terminer par 'en'
-- Ou par 'an'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
From Employee Emp
WHERE Emp.FIRST_NAME LIKE '%en'
OR Emp.FIRST_NAME LIKE '%an'

-- Requête de recherche des employés donc le prénom est 'Susan'
-- Et le nom 'Barker'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM Employee Emp
WHERE Emp.FIRST_NAME = 'susan'
AND Emp.LAST_NAME ='barker'