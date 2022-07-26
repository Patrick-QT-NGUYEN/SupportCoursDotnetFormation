-- Affichage de la table Transaction
Select * From ACC_TRANSACTION
-- Affichage de la table Account
Select * From Account

-- Insertion multiple dans la table ACC_TRANSACTION
-- Utilisation d'un SELECT pour fournir les données
-- La clé primaire est autogénérée (Txn_Id)
INSERT INTO ACC_TRANSACTION
			(TXN_DATE,
			ACCOUNT_ID,
			TXN_TYPE_CD,
			AMOUNT,
			FUNDS_AVAIL_DATE			
			)
SELECT Acc.OPEN_DATE, --TXN_DATE
		Acc.ACCOUNT_ID, --ACCOUNT_ID
		'CDT', --TXN_TYPE_CD
		Acc.AVAIL_BALANCE, --AMOUNT
		Acc.OPEN_DATE --FUNDS_AVAIL_DATE
FROM Account Acc
WHERE Acc.Product_Cd = 'CD'

-- Affichage de la table Transaction
Select * From ACC_TRANSACTION