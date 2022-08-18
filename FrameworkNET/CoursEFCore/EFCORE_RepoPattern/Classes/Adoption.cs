using System;
using System.Collections.Generic;

namespace EFCORE_RepoPattern.Classes
{
    public partial class Adoption
    {
        public int Id { get; set; }
        public DateTime DateOfAdoption { get; set; }
        public int DogId { get; set; }
        public int MasterId { get; set; }

        public virtual Dog Dog { get; set; } = null!;
        public virtual Master Master { get; set; } = null!;
    }
}
