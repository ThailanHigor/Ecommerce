using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infra.Data.EntityConfig
{
    internal static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(
          this ModelBuilder modelBuilder,
          IEntityConfig<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }

    public abstract class IEntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
