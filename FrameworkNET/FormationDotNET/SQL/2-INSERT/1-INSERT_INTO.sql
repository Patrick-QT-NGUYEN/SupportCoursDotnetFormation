-- Affichage de la table Acc_Transaction
SELECT * FROM ACC_TRANSACTION

-- Pour inserrer une transaction dans la table ACC_TRANSACTION:
-- Génération automatique de la colonne TXN_ID
-- Utilisation de Current_TimeStamp pour retourner la date et l'heure au moment de l'opération (SQL Server)
INSERT INTO ACC_TRANSACTION
			(AMOUNT,
			FUNDS_AVAIL_DATE,
			TXN_DATE,
			TXN_TYPE_CD,
			ACCOUNT_ID,
			EXECUTION_BRANCH_ID,
			TELLER_EMP_ID)
VALUES (150, --Amount
		CURRENT_TIMESTAMP, -- FUNDS_AVAIL_DATE
		CURRENT_TIMESTAMP, -- TXN_DATE
		'CDT', --TXN_TYPE_CD
		4, -- ACCOUNT_ID
		Null, --EXECUTION_BRANCH_ID
		Null) --TELLER_EMP_ID

-- Affichage de la table Acc_Transaction
SELECT * FROM ACC_TRANSACTION