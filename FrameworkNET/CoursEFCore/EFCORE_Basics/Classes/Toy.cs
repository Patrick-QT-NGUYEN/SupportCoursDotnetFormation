using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Basics.Classes
{
    internal class Toy
    {
        // [Key] // Optionnel
        public int Id { get; set; }

        [StringLength(50)] // Pour économiser de la place en BdD
        [Required] // Pour éviter les problèmes lors de futurs appels API au niveau des contrôleurs
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; } // Ici, la description devient optionnelle car nullable
    }
}
