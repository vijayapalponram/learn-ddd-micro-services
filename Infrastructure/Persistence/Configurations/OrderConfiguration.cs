using Domain.Aggregates;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id);
            
            builder.HasOne<Customer>().WithMany().HasForeignKey(o => o.CustomerId).IsRequired();

            builder.HasMany<OrderLineItem>().WithOne().HasForeignKey(li => li.OrderId);
        }
    }
}