using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class model_updatesV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
