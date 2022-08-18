using EFCORE_RepoPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    internal class BrandsRepository : BaseRepository, IRepository<Brand>
    {
        public bool Add(Brand element)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Brand element)
        {
            throw new NotImplementedException();
        }

        public ICollection<Brand> Filter(Func<Brand, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Brand? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Brand element)
        {
            throw new NotImplementedException();
        }
    }
}
