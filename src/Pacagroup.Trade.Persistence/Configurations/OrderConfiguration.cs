using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacagroup.Trade.Domain.Entities;

namespace Pacagroup.Trade.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                   .HasPrecision(9,0)
                   .IsRequired()
                   .ValueGeneratedNever();
            
            builder.Property(o => o.Symbol)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(o => o.Side)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(o => o.TransactTime)
                   .IsRequired();

            builder.Property(o => o.Quantity)
                   .HasPrecision(9,0)
                   .IsRequired(); 

            builder.Property(o => o.Type)
                   .HasMaxLength(1)
                   .IsRequired();

            builder.Property(o => o.Price)
                   .HasPrecision(9,4)
                   .IsRequired();
        }
    }
}
