using EFCORE_RepoPattern.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    // Enfin, on créé notre classe de repository (une par modèle de données - classe)
    // Leur nom doit idéalement être le nom de notre modèle de donnée pluralisé
    internal class DogsRepository : BaseRepository, IRepository<Dog>
    {
        public bool Add(Dog element)
        {
            _context.Dogs.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(Dog element)
        {
            _context.Dogs.Remove(element);

            return _context.SaveChanges() == 1;
        }

        public ICollection<Dog> Filter(Func<Dog, bool> predicate)
        {
            return _context.Dogs
                .Include(x => x.Toys).ThenInclude(x => x.Brand)
                .Include(x => x.Adoptions)
                .Where(predicate)
                .ToList();
        }

        public ICollection<Dog> GetAll()
        {
            return _context.Dogs
                .Include(x => x.Toys).ThenInclude(x => x.Brand)
                .Include(x => x.Adoptions)
                .ToList();
        }

        public Dog? GetById(int id)
        {
            return _context.Dogs
                .Include(x => x.Toys).ThenInclude(x => x.Brand)
                .Include(x => x.Adoptions)
                .FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Dog element)
        {
            _context.Update(element);

            return _context.SaveChanges() >= 1;
        }
    }
}
