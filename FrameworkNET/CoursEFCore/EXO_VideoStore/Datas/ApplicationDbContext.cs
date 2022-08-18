using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP05.Classes;

namespace TP05.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Emprunt> Emprunts { get; set; }

        // FACULTATIF : On créé ici un Singleton pour s'assurer qu'il ny a qu'une seule et unique instance d'ApplicationDbContext
        // dans toute notre application
        private static ApplicationDbContext instance;
        
        public static ApplicationDbContext Instance
        {
            get
            {
                if (instance == null) return new ApplicationDbContext();
                else return instance;
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sécurisation de la chaine de connexion de notre Application via
            // l'utilisation du fichier secrets.json
            var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddUserSecrets<Program>()
            .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
            // Si l'on ne veut pas sécuriser notre chaine de connexion, on peut la mettre en dur de la sorte 
            //
            // optionsBuilder.UseSqlServer("ICI JE METS SIMPLEMENT MA CHAINE DE CONNEXION"));
        }
    }
}
