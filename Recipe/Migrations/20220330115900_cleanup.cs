using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 3, 30, 11, 59, 0, 463, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 3, 30, 11, 59, 0, 463, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 3, 30, 11, 59, 0, 463, DateTimeKind.Utc).AddTicks(6016));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 27, 59, 127, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 27, 59, 128, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 27, 59, 128, DateTimeKind.Utc).AddTicks(161));
        }
    }
}
