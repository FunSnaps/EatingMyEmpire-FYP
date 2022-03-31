using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class model_updatesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 26, 3, 844, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 26, 3, 844, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 3, 29, 14, 26, 3, 844, DateTimeKind.Utc).AddTicks(6835));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
