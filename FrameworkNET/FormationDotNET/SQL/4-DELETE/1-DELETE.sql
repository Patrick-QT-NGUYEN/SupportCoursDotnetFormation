-- Affichage de la table Acc_transaction
SELECT * FROM ACC_TRANSACTION
Order By TXN_ID DESC

-- Suppression des entrées faites dans la table Acc_Transaction avec in
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID in (25, 26)

-- Suppression des entrées faites dans la table Acc_Transaction avec Between
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID 
Between 22
And 24

-- Affichage de la table Acc_transaction
SELECT * FROM ACC_TRANSACTION
Order By TXN_ID DESC
