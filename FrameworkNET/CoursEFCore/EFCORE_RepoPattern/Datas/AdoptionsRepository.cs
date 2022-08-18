using EFCORE_RepoPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    internal class AdoptionsRepository : BaseRepository, IRepository<Adoption>
    {
        public bool Add(Adoption element)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Adoption element)
        {
            throw new NotImplementedException();
        }

        public ICollection<Adoption> Filter(Func<Adoption, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<Adoption> GetAll()
        {
            throw new NotImplementedException();
        }

        public Adoption? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Adoption element)
        {
            throw new NotImplementedException();
        }
    }
}
