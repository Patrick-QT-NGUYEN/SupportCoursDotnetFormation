using System;
using System.Collections.Generic;

namespace EFCORE_RepoPattern.Classes
{
    public partial class Brand
    {
        public Brand()
        {
            Toys = new HashSet<Toy>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
