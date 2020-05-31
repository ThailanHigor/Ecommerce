using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infra.Data.EntityConfig
{
    internal class ProdutoConfig : IEntityConfig<Produto>
    {
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}
