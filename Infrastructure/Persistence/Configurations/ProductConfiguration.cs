using System.Data.Common;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasConversion(
                productId => productId.Value,
                value => new ProductId(value));

            builder.Property(p => p.Name).HasMaxLength(500);

            builder.OwnsOne(p=>p.Price, priceBuilder=>{
                priceBuilder.Property(m => m.Currency);
            });
        }
    }
}