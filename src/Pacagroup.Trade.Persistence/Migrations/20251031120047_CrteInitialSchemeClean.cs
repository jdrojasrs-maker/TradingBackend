using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pacagroup.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CrteInitialSchemeClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactTime",
                value: new DateTime(2025, 10, 21, 12, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactTime",
                value: new DateTime(2025, 10, 23, 12, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactTime",
                value: new DateTime(2025, 10, 26, 12, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactTime",
                value: new DateTime(2025, 10, 28, 12, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactTime",
                value: new DateTime(2025, 10, 21, 11, 41, 37, 93, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactTime",
                value: new DateTime(2025, 10, 23, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactTime",
                value: new DateTime(2025, 10, 26, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactTime",
                value: new DateTime(2025, 10, 28, 11, 41, 37, 94, DateTimeKind.Utc).AddTicks(474));
        }
    }
}
