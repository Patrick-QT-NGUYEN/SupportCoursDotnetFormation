using EFCORE_RepoPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    internal class MastersRepository : BaseRepository, IRepository<Master>
    {
        public bool Add(Master element)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Master element)
        {
            throw new NotImplementedException();
        }

        public ICollection<Master> Filter(Func<Master, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<Master> GetAll()
        {
            throw new NotImplementedException();
        }

        public Master? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Master element)
        {
            throw new NotImplementedException();
        }
    }
}
