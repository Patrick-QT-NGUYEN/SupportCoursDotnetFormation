﻿-- Requête pour voir le contenu des données de la table Product_Type
SELECT PRODUCT_TYPE_CD,NAME FROM Product_Type;


-- Requête pour voir le contenu des données de la table Product_Type Avec Alias
SELECT Pty.PRODUCT_TYPE_CD,Pty.NAME FROM Product_Type AS Pty;


-- Requête pour voir des champs précis de la table employee
SELECT Emp.Emp_Id, Emp.First_name,Emp.last_name, Emp.title, Emp.dept_id
FROM EMPLOYEE AS Emp