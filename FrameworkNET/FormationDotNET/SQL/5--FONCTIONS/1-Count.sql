-- La fonction Count() permet de compter le nombre de ligne en correspondance avec nos critères de séléction
--select * from employee
-- Compte le nombre de ligne dans une table (Employee)
SELECT * FROM Employee
SELECT Count(Emp.EMP_ID) As Nb_Employes 
From Employee Emp

-- Affichage de la table ACCOUNT
select * from ACCOUNT
-- Compte le nombre de client unique qui détiennent au moins un compte dans la banque
SELECT Count(DISTINCT Acc.Cust_Id) As DistinctClient 
FROM ACCOUNT Acc

-- Lister les clients et leurs comptes
SELECT Acc.CUST_ID,
		Count(Acc.ACCOUNT_ID) AS Nb_Compte
FROM ACCOUNT Acc
Group By Acc.CUST_ID