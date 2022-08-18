using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Basics.Classes
{
    internal class Dog
    {
        // L'annotation Key sert à définir quelle est la clé primaire de notre modèle
        [Key] // Cette annotation est optionnelle car nous respectons le nom conventionné de notre prop
        public int Id { get; set; }

        // L'annotation StringLength(x) sert à définir la taille maximale de notre texte une fois en SQL
        [StringLength(80)]

        // L'annotation Required sert à s'assurer que la propriété est alimentée en cas d'ajout d'un chien
        [Required]
        public string Name { get; set; }
        
        [StringLength(80)]
        [Required]
        public string Breed { get; set; }

        [Required]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} (Race : {Breed}) - {Age} ans";
        }

    }
}
