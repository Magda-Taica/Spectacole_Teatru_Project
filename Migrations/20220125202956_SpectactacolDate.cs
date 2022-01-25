using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spectacole_Teatru_Project.Migrations
{
    public partial class SpectactacolDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Spectacol",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "SpectacolDate",
                table: "Spectacol",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpectacolDate",
                table: "Spectacol");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Spectacol",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
