using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pacagroup.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CrteInitialScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", precision: 9, scale: 0, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Side = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TransactTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", precision: 9, scale: 0, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Price", "Quantity", "Side", "Symbol", "TransactTime", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 522.99m, 1000, 0, "META", new DateTime(2025, 10, 21, 11, 41, 37, 93, DateTimeKind.Utc).AddTicks(9911), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 145.50m, 50, 0, "AAPL", new DateTime(2025, 10, 23, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(468), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 30, 1, "TSLA", new DateTime(2025, 10, 26, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(472), 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 200, 0, "AMZN", new DateTime(2025, 10, 28, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(474), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
