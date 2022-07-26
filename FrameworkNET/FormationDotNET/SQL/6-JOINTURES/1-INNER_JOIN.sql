-- Le mot clé INNER JOIN permet de retourner les enregistrements lorqu'il y a au moins une ligne dans chaque colonne qui correspond à la condition

----Syntax
--SELECT Nom_Colonne
--FROM table 1
--INNER JOIN table 2
--ON table1.Nom_Colonne = table2.Nom_Colonne

----INNER JOIN peut-être par JOIN (comportement par defaut des jointures)
--SELECT Nom_Colonne
--FROM table 1
--JOIN table 2
--ON table1.Nom_Colonne = table2.Nom_Colonne

--Exemple
-- Affichage de la table Employee
SELECT * FROM EMPLOYEE

-- Affichage de la table DEPARTMENT
SELECT * FROM DEPARTMENT

-- INNER JOIN de 2 tables : EMPLOYEE et DEPARTMENT
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE,
		--Emp.DEPT_ID,
		Dep.NAME As Dep_Name
FROM EMPLOYEE Emp
INNER JOIN DEPARTMENT Dep
ON Emp.DEPT_ID = Dep.DEPT_ID
Order By Dep_Name

-- Syntaxe propre à SQL SERVER (Même résultat)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		--Emp.DEPT_ID,
		Dep.NAME As Dep_Name
FROM EMPLOYEE Emp, DEPARTMENT Dep
WHERE Emp.DEPT_ID = Dep.DEPT_ID
Order By Emp.DEPT_ID