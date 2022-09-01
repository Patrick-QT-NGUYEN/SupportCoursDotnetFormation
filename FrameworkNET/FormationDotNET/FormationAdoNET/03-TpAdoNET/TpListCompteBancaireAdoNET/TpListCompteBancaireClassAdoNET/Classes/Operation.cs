using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListCompteBancaireClassAdoNET.Classes
{
    public class Operation
    {
        private int id;
        private int idCompte;
        private decimal montant;
        private DateTime dateOperation;
        

        public int Id { get => id; init => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }
        public int IdCompte { get => idCompte; set => idCompte = value; }

        public Operation(int idCompte ,decimal montant)
        {
            IdCompte = idCompte;
            Montant = montant;
            DateOperation = DateTime.Now;
        }

        public Operation(int id, int idCompte, DateTime dateOperation, decimal montant)
        {
            Id = id;
            Montant = montant;
            DateOperation = dateOperation;
            IdCompte = idCompte;
        }

        public override string ToString()
        {
            return $" Id : {(Id > 9 ? id : "0" + Id)}, Date : {DateOperation}";
        }
    }
}
