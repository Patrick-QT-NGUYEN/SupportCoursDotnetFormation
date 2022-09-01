﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListCompteBancaireClassAdoNET.Classes;
using TpListCompteBancaireClassAdoNET.Tools;

namespace TpListCompteBancaireClassAdoNET.DAO
{
    public class OperationDAO : BaseDAO<Operation>
    {
        public override int Create(Operation element)
        {
            _connection = Connection.New;
            _command = new SqlCommand("INSERT INTO operation (compte_id,date_Operation, montant) VALUES (@IdCompte, @DateOperation, @Montant)", _connection);
            _command.Parameters.Add(new SqlParameter("@IdCompte", element.IdCompte));
            _command.Parameters.Add(new SqlParameter("@DateOperation", element.DateOperation));
            _command.Parameters.Add(new SqlParameter("@Montant", element.Montant));
            _connection.Open();
            int nbLigne = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return nbLigne;
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Operation element)
        {
            throw new NotImplementedException();
        }

        public override Operation Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Operation> Find(Func<Operation, bool> criteria)
        {
            List<Operation> operations = new List<Operation>();
            FindAll().ForEach(c =>
            {
                if (criteria(c))
                {
                    operations.Add(c);
                }
            });
            return operations;
        }

        public override List<Operation> FindAll()
        {
            _connection = Connection.New;

            List<Operation> liste = new List<Operation>();

            _request = "SELECT * FROM operation ";

            _command = new SqlCommand(_request, _connection);

            _connection.Open();

            _reader = _command.ExecuteReader();

            while (_reader.Read())
            {
                Operation o = new Operation(_reader.GetInt32(0), _reader.GetInt32(3), _reader.GetDateTime(2), _reader.GetDecimal(1));
                liste.Add(o);
            }

            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return liste;
        }

        public override bool Update(Operation element)
        {
            throw new NotImplementedException();
        }
    }
}
