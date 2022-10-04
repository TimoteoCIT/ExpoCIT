using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpoCIT.Migrations
{
    public partial class Anadirsegundoapellidoajuez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Jueces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Jueces");
        }
    }
}
