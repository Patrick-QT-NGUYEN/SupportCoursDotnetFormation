using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_RepoPattern.Datas
{
    // Pour facilité l'utilisation du Repository Pattern, il est courant de se servir d'une classe abstraite
    // qui va contenir le lien avec le contexte de données
    internal abstract class BaseRepository
    {
        // Il lui faudra une propriété protégée (récupérée par les classes qui vont hériter de notre classe abstraite)
        // qui servira à avoir le lien vers le contexte de données
        protected ApplicationDbContext _context = new();
    }
}
