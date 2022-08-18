using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFCORE_RepoPattern.Classes;

namespace EFCORE_RepoPattern.Datas
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adoption> Adoptions { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Dog> Dogs { get; set; } = null!;
        public virtual DbSet<Master> Masters { get; set; } = null!;
        public virtual DbSet<Toy> Toys { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\MSSQLLOCALDB; Initial Catalog = PRF2022_EFCore_Demo_Jointures; Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adoption>(entity =>
            {
                entity.HasIndex(e => e.DogId, "IX_Adoptions_DogId");

                entity.HasIndex(e => e.MasterId, "IX_Adoptions_MasterId");

                entity.HasOne(d => d.Dog)
                    .WithMany(p => p.Adoptions)
                    .HasForeignKey(d => d.DogId);

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.Adoptions)
                    .HasForeignKey(d => d.MasterId);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.Property(e => e.Breed).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.ToTable("Master");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.HasIndex(e => e.BrandId, "IX_Toys_BrandId");

                entity.HasIndex(e => e.DogId, "IX_Toys_DogId");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Toys)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Dog)
                    .WithMany(p => p.Toys)
                    .HasForeignKey(d => d.DogId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
