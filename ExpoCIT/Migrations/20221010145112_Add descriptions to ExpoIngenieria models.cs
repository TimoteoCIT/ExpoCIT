using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpoCIT.Migrations
{
    public partial class AdddescriptionstoExpoIngenieriamodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DG",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "III_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_f_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_f_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_a_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_b_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_c_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_d_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_e_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_f_descripcion",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DG",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "III_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "III_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "II_f_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IV_f_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIII_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VII_f_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_f_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_g_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VI_h_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_a_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_b_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_c_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_d_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_e_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_f_descripcion",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "III_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "III_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "III_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "III_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "II_f_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "IV_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "IV_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "IV_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "IV_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "IV_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "I_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "I_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "I_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "I_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "I_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VIII_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VIII_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VIII_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VIII_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VIII_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VII_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VII_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VII_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VII_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VII_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "VI_f_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_a_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_b_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_c_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_d_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_e_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "V_f_descripcion",
                table: "RTEIs");

            migrationBuilder.DropColumn(
                name: "III_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "III_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "III_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "III_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "III_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "II_f_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "IV_f_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "I_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "I_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "I_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "I_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "I_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VIII_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VIII_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VIII_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VIII_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VII_f_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_f_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_g_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "VI_h_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_a_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_b_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_c_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_d_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_e_descripcion",
                table: "RPEIs");

            migrationBuilder.DropColumn(
                name: "V_f_descripcion",
                table: "RPEIs");

            migrationBuilder.AlterColumn<string>(
                name: "DG",
                table: "RTEIs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DG",
                table: "RPEIs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
