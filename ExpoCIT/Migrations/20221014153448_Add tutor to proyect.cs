using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpoCIT.Migrations
{
    public partial class Addtutortoproyect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tutor",
                table: "Proyectos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tutor",
                table: "Proyectos");
        }
    }
}
