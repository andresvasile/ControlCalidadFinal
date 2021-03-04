using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Data.Migrations{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Colores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colores",
                table: "Colores",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Colores",
                table: "Colores");

            migrationBuilder.RenameTable(
                name: "Colores",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");
        }
    }
}
