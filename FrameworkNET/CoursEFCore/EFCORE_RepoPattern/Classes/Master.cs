using System;
using System.Collections.Generic;

namespace EFCORE_RepoPattern.Classes
{
    public partial class Master
    {
        public Master()
        {
            Adoptions = new HashSet<Adoption>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}
