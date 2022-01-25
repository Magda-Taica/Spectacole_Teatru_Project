using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spectacole_Teatru_Project.Migrations
{
    public partial class CategorieSpectacol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegizorID",
                table: "Spectacol",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regizor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Regizor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regizor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieSpectacol",
                columns: table => new
                {
                    CategoriiSpectacolID = table.Column<int>(type: "int", nullable: false),
                    CategoriiSpectacolID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieSpectacol", x => new { x.CategoriiSpectacolID, x.CategoriiSpectacolID1 });
                    table.ForeignKey(
                        name: "FK_CategorieSpectacol_Categorie_CategoriiSpectacolID1",
                        column: x => x.CategoriiSpectacolID1,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieSpectacol_Spectacol_CategoriiSpectacolID",
                        column: x => x.CategoriiSpectacolID,
                        principalTable: "Spectacol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spectacol_RegizorID",
                table: "Spectacol",
                column: "RegizorID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieSpectacol_CategoriiSpectacolID1",
                table: "CategorieSpectacol",
                column: "CategoriiSpectacolID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Spectacol_Regizor_RegizorID",
                table: "Spectacol",
                column: "RegizorID",
                principalTable: "Regizor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spectacol_Regizor_RegizorID",
                table: "Spectacol");

            migrationBuilder.DropTable(
                name: "CategorieSpectacol");

            migrationBuilder.DropTable(
                name: "Regizor");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Spectacol_RegizorID",
                table: "Spectacol");

            migrationBuilder.DropColumn(
                name: "RegizorID",
                table: "Spectacol");
        }
    }
}
