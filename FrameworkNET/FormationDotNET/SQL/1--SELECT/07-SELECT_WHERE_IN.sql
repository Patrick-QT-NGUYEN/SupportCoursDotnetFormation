-- Requête permettant de rechercher des employés avec des critères multiple sur le même champs
-- Susan, Paula, Helen

SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM Employee Emp
WHERE Emp.FIRST_NAME IN ('Susan', 'Paula', 'Helen')