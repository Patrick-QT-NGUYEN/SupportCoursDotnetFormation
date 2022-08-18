using EFCORE_RepoPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    internal class ToysRepository : BaseRepository, IRepository<Toy>
    {
        public bool Add(Toy element)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Toy element)
        {
            throw new NotImplementedException();
        }

        public ICollection<Toy> Filter(Func<Toy, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<Toy> GetAll()
        {
            throw new NotImplementedException();
        }

        public Toy? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Toy element)
        {
            throw new NotImplementedException();
        }
    }
}
