using EFCORE_RepoPattern.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Classes
{
    internal class IHM
    {
        // Lors de l'utilisation du Repo Pattern en mode console il nous faut instancier
        // des Repositories pour chacun de nos modèles de données
        private IRepository<Dog> _dogsRepo;
        private IRepository<Toy> _toysRepo;
        private IRepository<Master> _mastersRepo;
        private IRepository<Adoption> _adoptionsRepo;
        private IRepository<Brand> _brandsRepo;

        public IHM(IRepository<Dog> dogsRepo, 
            IRepository<Toy> toysRepo, 
            IRepository<Master> mastersRepo, 
            IRepository<Adoption> adoptionsRepo, 
            IRepository<Brand> brandsRepo)
        {
            // Une fois l'inversion de contrôle vue et utilisée, il y aura ce genre de syntaxe
            //_dogsRepo = dogsRepo
            //_brandsRepo = brandsRepo;
            //_adoptionsRepo = adoptionsRepo;
            //_mastersRepo = mastersRepo;
            //_toysRepo = toysRepo;
        }

        public IHM()
        {
            // Pour une application sans inversion de contrôle (comme nous le faisons pour le moment),
            // il nous faut nous-même instancier les différents repositories
            _dogsRepo = new DogsRepository();
            _brandsRepo = new BrandsRepository();
            _adoptionsRepo = new AdoptionsRepository();
            _mastersRepo = new MastersRepository();
            _toysRepo = new ToysRepository();
        }


    }
}
