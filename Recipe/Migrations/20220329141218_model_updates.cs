using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class model_updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 12, 18, 540, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 12, 18, 540, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 12, 18, 540, DateTimeKind.Utc).AddTicks(8232));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 9, 44, 23, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 9, 44, 23, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 9, 44, 23, DateTimeKind.Utc).AddTicks(2845));
        }
    }
}
