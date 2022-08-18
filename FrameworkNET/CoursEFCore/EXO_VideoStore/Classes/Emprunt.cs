using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05.Classes
{
    internal class Emprunt
    {
        public int Id { get; set; }
        public DateTime EmprunteLe { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Film> Films { get; set; } = new();
        // public ICollection<Film> Films { get; set; } = new();
    }
}
