using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiAsincrona.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Expediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delegado = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Expediente);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Modulo_Alumno",
                columns: table => new
                {
                    IdModulo_Alumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Alumno = table.Column<int>(type: "int", nullable: false),
                    Codigo_Modulo = table.Column<int>(type: "int", nullable: false),
                    AlumnoExpediente = table.Column<int>(type: "int", nullable: true),
                    ModuloCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo_Alumno", x => x.IdModulo_Alumno);
                    table.ForeignKey(
                        name: "FK_Modulo_Alumno_Alumno_AlumnoExpediente",
                        column: x => x.AlumnoExpediente,
                        principalTable: "Alumno",
                        principalColumn: "Expediente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modulo_Alumno_Modulo_ModuloCodigo",
                        column: x => x.ModuloCodigo,
                        principalTable: "Modulo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    RFC = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuloCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.RFC);
                    table.ForeignKey(
                        name: "FK_Profesor_Modulo_ModuloCodigo",
                        column: x => x.ModuloCodigo,
                        principalTable: "Modulo",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_Alumno_AlumnoExpediente",
                table: "Modulo_Alumno",
                column: "AlumnoExpediente");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_Alumno_ModuloCodigo",
                table: "Modulo_Alumno",
                column: "ModuloCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_ModuloCodigo",
                table: "Profesor",
                column: "ModuloCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modulo_Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Modulo");
        }
    }
}
