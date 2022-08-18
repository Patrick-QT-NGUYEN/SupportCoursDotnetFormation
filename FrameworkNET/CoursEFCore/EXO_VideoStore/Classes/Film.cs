using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05.Classes
{
    internal class Film
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }
        
        [StringLength(50)]
        public string Realisateur { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int Score { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }

        public int? EmpruntId { get; set; }
        public virtual Emprunt? Emprunt { get; set; }
    }
}
