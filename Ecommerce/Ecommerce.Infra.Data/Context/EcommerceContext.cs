using Ecommerce.Domain.Entities;
using Ecommerce.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ecommerce.Infra.Data.Context
{
    public class EcommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UTRNH3C\SQLEXPRESS;Database=Ecommerce;Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new ProdutoConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("CreatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                    entry.Property("UpdatedAt").CurrentValue = null;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedAt").IsModified = false;
                    entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
