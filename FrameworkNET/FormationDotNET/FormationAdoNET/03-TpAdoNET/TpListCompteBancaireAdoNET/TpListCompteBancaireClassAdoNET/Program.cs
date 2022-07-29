
using TpListCompteBancaireClassAdoNET.Classes;
using TpListCompteBancaireClassAdoNET.DAO;

#region Test Ajout d'un client
ClientDAO _clientDAO = new();

Client c = new Client("Di Persio", "Anthony", "+33 6 41 52 63 98");
_clientDAO.Create(c);
#endregion












Console.WriteLine("à Bientôt...");
