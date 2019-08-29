using Microsoft.EntityFrameworkCore.Migrations;

namespace MetalBroxstarChaos.Datos.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    idClase = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombreClase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.idClase);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    idPersonaje = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombrePersonaje = table.Column<string>(nullable: true),
                    nivelPersonaje = table.Column<int>(nullable: false),
                    idClase = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.idPersonaje);
                    table.ForeignKey(
                        name: "FK_Personajes_Clases_idClase",
                        column: x => x.idClase,
                        principalTable: "Clases",
                        principalColumn: "idClase",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    idHabilidad = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idPersonaje = table.Column<int>(nullable: false),
                    nombreHabilidad = table.Column<string>(nullable: true),
                    poder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.idHabilidad);
                    table.ForeignKey(
                        name: "FK_Habilidades_Personajes_idPersonaje",
                        column: x => x.idPersonaje,
                        principalTable: "Personajes",
                        principalColumn: "idPersonaje",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "idClase", "nombreClase" },
                values: new object[] { 1, "Guerrero" });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "idClase", "nombreClase" },
                values: new object[] { 2, "Mago" });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "idClase", "nombreClase" },
                values: new object[] { 3, "Paladín" });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "idClase", "nombreClase" },
                values: new object[] { 4, "Pícaro" });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_idPersonaje",
                table: "Habilidades",
                column: "idPersonaje");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_idClase",
                table: "Personajes",
                column: "idClase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Clases");
        }
    }
}
