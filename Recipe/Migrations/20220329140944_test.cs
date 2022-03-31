using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
