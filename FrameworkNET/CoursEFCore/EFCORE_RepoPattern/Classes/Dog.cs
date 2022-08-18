using System;
using System.Collections.Generic;

namespace EFCORE_RepoPattern.Classes
{
    public partial class Dog
    {
        public Dog()
        {
            Adoptions = new HashSet<Adoption>();
            Toys = new HashSet<Toy>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Breed { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<Adoption> Adoptions { get; set; }
        public virtual ICollection<Toy> Toys { get; set; }
    }
}
