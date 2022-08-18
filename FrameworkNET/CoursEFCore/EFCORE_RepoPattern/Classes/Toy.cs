using System;
using System.Collections.Generic;

namespace EFCORE_RepoPattern.Classes
{
    public partial class Toy
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? BrandId { get; set; }
        public int? DogId { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Dog? Dog { get; set; }
    }
}
