using Domain.Aggregates;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class OrderLineItemConfiguration : IEntityTypeConfiguration<OrderLineItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderLineItem> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).HasConversion(
                lineItemId => lineItemId.Value,
                value => new OrderLineItemId(value));
            
            builder.HasOne<Product>().WithMany().HasForeignKey(li=>li.ProductId);

            builder.OwnsOne(li=>li.Price, priceBuilder=>{
                priceBuilder.Property(m => m.Value);
            });      
        }
    }
}