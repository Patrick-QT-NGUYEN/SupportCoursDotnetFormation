
select * FROM Livre

-- Supprimmer une entrée ( ou plusieurs) de la table livre
DELETE FROM livre
WHERE auteur = 'Jules Verne'
AND titre ='Le tour du monde en 80 jours'

--DELETE FROM livre
--WHERE auteur = 'Napoleon Hill'
--AND titre ='Réflichissez et devenez riche'


select * from livre