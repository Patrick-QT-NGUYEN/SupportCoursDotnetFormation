using EFCORE_Basics.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Basics.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        // Pour avoir accès par la suite à la table de chiens, il nous faut un DbSet de chiens (publique)
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Toy> Toys { get; set; }

        // Pour gérer la configuration du lien avec la base de donnée, il nous faut avoir accès à la méthode
        //
        // OnConfiguring() dans laquelle nous pourrons avoir notre chaine de connexion SQLServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Program>()
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"))
                // Si l'on veut avoir un log de ce qu'il se passe dans EF Core et observer les requêtes SQL générées
                // pour nous, il suffit d'adjointe la méthode .LogTo() après .UseSqlServer()
                .LogTo(Console.WriteLine, LogLevel.Information); 
        }
    }
}
