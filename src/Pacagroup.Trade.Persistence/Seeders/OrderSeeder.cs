using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacagroup.Trade.Domain.Entities;

namespace Pacagroup.Trade.Persistence.Seeders
{
    public class OrderSeeder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
            new Order
            {
                Id = 1,
                Symbol = "META",
                Side = Domain.Enums.OrderSide.BUY,
                TransactTime = new DateTime(2025, 10, 21, 12, 0, 0, DateTimeKind.Utc),
                Quantity = 1000,
                Type = Domain.Enums.OrderType.LIMIT,
                Price = 522.99M
            },
            new Order
            {
                Id = 2,
                Symbol = "AAPL",
                Side = Domain.Enums.OrderSide.BUY,
                TransactTime = new DateTime(2025, 10, 23, 12, 0, 0, DateTimeKind.Utc),
                Quantity = 50,
                Type = Domain.Enums.OrderType.LIMIT,
                Price = 145.50M
            },
            new Order
            {
                Id = 3,
                Symbol = "TSLA",
                Side = Domain.Enums.OrderSide.SELL,
                TransactTime = new DateTime(2025, 10, 26, 12, 0, 0, DateTimeKind.Utc),
                Quantity = 30,
                Type = Domain.Enums.OrderType.MARKET,
                Price = 0
            },
            new Order
            {
                Id = 4,
                Symbol = "AMZN",
                Side = Domain.Enums.OrderSide.BUY,
                TransactTime = new DateTime(2025, 10, 28, 12, 0, 0, DateTimeKind.Utc),
                Quantity = 200,
                Type = Domain.Enums.OrderType.MARKET,
                Price = 0
            });
        }
    }
}
