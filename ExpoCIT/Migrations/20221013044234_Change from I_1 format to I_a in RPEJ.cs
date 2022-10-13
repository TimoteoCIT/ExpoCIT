using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpoCIT.Migrations
{
    public partial class ChangefromI_1formattoI_ainRPEJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "V_27",
                table: "RTEJs",
                newName: "V_e");

            migrationBuilder.RenameColumn(
                name: "V_26",
                table: "RTEJs",
                newName: "V_d");

            migrationBuilder.RenameColumn(
                name: "V_25",
                table: "RTEJs",
                newName: "V_c");

            migrationBuilder.RenameColumn(
                name: "V_24",
                table: "RTEJs",
                newName: "V_b");

            migrationBuilder.RenameColumn(
                name: "V_23",
                table: "RTEJs",
                newName: "V_a");

            migrationBuilder.RenameColumn(
                name: "VI_31",
                table: "RTEJs",
                newName: "VI_d");

            migrationBuilder.RenameColumn(
                name: "VI_30",
                table: "RTEJs",
                newName: "VI_c");

            migrationBuilder.RenameColumn(
                name: "VI_29",
                table: "RTEJs",
                newName: "VI_b");

            migrationBuilder.RenameColumn(
                name: "VI_28",
                table: "RTEJs",
                newName: "VI_a");

            migrationBuilder.RenameColumn(
                name: "VII_35",
                table: "RTEJs",
                newName: "VII_d");

            migrationBuilder.RenameColumn(
                name: "VII_34",
                table: "RTEJs",
                newName: "VII_c");

            migrationBuilder.RenameColumn(
                name: "VII_33",
                table: "RTEJs",
                newName: "VII_b");

            migrationBuilder.RenameColumn(
                name: "VII_32",
                table: "RTEJs",
                newName: "VII_a");

            migrationBuilder.RenameColumn(
                name: "I_5",
                table: "RTEJs",
                newName: "I_e");

            migrationBuilder.RenameColumn(
                name: "I_4",
                table: "RTEJs",
                newName: "I_d");

            migrationBuilder.RenameColumn(
                name: "I_3",
                table: "RTEJs",
                newName: "I_c");

            migrationBuilder.RenameColumn(
                name: "I_2",
                table: "RTEJs",
                newName: "I_b");

            migrationBuilder.RenameColumn(
                name: "I_1",
                table: "RTEJs",
                newName: "I_a");

            migrationBuilder.RenameColumn(
                name: "IV_22",
                table: "RTEJs",
                newName: "IV_f");

            migrationBuilder.RenameColumn(
                name: "IV_21",
                table: "RTEJs",
                newName: "IV_e");

            migrationBuilder.RenameColumn(
                name: "IV_20",
                table: "RTEJs",
                newName: "IV_d");

            migrationBuilder.RenameColumn(
                name: "IV_19",
                table: "RTEJs",
                newName: "IV_c");

            migrationBuilder.RenameColumn(
                name: "IV_18",
                table: "RTEJs",
                newName: "IV_b");

            migrationBuilder.RenameColumn(
                name: "IV_17",
                table: "RTEJs",
                newName: "IV_a");

            migrationBuilder.RenameColumn(
                name: "II_9",
                table: "RTEJs",
                newName: "II_f");

            migrationBuilder.RenameColumn(
                name: "II_8",
                table: "RTEJs",
                newName: "II_e");

            migrationBuilder.RenameColumn(
                name: "II_7",
                table: "RTEJs",
                newName: "II_d");

            migrationBuilder.RenameColumn(
                name: "II_6",
                table: "RTEJs",
                newName: "II_c");

            migrationBuilder.RenameColumn(
                name: "II_11",
                table: "RTEJs",
                newName: "II_b");

            migrationBuilder.RenameColumn(
                name: "II_10",
                table: "RTEJs",
                newName: "II_a");

            migrationBuilder.RenameColumn(
                name: "III_16",
                table: "RTEJs",
                newName: "III_e");

            migrationBuilder.RenameColumn(
                name: "III_15",
                table: "RTEJs",
                newName: "III_d");

            migrationBuilder.RenameColumn(
                name: "III_14",
                table: "RTEJs",
                newName: "III_c");

            migrationBuilder.RenameColumn(
                name: "III_13",
                table: "RTEJs",
                newName: "III_b");

            migrationBuilder.RenameColumn(
                name: "III_12",
                table: "RTEJs",
                newName: "III_a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "V_e",
                table: "RTEJs",
                newName: "V_27");

            migrationBuilder.RenameColumn(
                name: "V_d",
                table: "RTEJs",
                newName: "V_26");

            migrationBuilder.RenameColumn(
                name: "V_c",
                table: "RTEJs",
                newName: "V_25");

            migrationBuilder.RenameColumn(
                name: "V_b",
                table: "RTEJs",
                newName: "V_24");

            migrationBuilder.RenameColumn(
                name: "V_a",
                table: "RTEJs",
                newName: "V_23");

            migrationBuilder.RenameColumn(
                name: "VI_d",
                table: "RTEJs",
                newName: "VI_31");

            migrationBuilder.RenameColumn(
                name: "VI_c",
                table: "RTEJs",
                newName: "VI_30");

            migrationBuilder.RenameColumn(
                name: "VI_b",
                table: "RTEJs",
                newName: "VI_29");

            migrationBuilder.RenameColumn(
                name: "VI_a",
                table: "RTEJs",
                newName: "VI_28");

            migrationBuilder.RenameColumn(
                name: "VII_d",
                table: "RTEJs",
                newName: "VII_35");

            migrationBuilder.RenameColumn(
                name: "VII_c",
                table: "RTEJs",
                newName: "VII_34");

            migrationBuilder.RenameColumn(
                name: "VII_b",
                table: "RTEJs",
                newName: "VII_33");

            migrationBuilder.RenameColumn(
                name: "VII_a",
                table: "RTEJs",
                newName: "VII_32");

            migrationBuilder.RenameColumn(
                name: "I_e",
                table: "RTEJs",
                newName: "I_5");

            migrationBuilder.RenameColumn(
                name: "I_d",
                table: "RTEJs",
                newName: "I_4");

            migrationBuilder.RenameColumn(
                name: "I_c",
                table: "RTEJs",
                newName: "I_3");

            migrationBuilder.RenameColumn(
                name: "I_b",
                table: "RTEJs",
                newName: "I_2");

            migrationBuilder.RenameColumn(
                name: "I_a",
                table: "RTEJs",
                newName: "I_1");

            migrationBuilder.RenameColumn(
                name: "IV_f",
                table: "RTEJs",
                newName: "IV_22");

            migrationBuilder.RenameColumn(
                name: "IV_e",
                table: "RTEJs",
                newName: "IV_21");

            migrationBuilder.RenameColumn(
                name: "IV_d",
                table: "RTEJs",
                newName: "IV_20");

            migrationBuilder.RenameColumn(
                name: "IV_c",
                table: "RTEJs",
                newName: "IV_19");

            migrationBuilder.RenameColumn(
                name: "IV_b",
                table: "RTEJs",
                newName: "IV_18");

            migrationBuilder.RenameColumn(
                name: "IV_a",
                table: "RTEJs",
                newName: "IV_17");

            migrationBuilder.RenameColumn(
                name: "II_f",
                table: "RTEJs",
                newName: "II_9");

            migrationBuilder.RenameColumn(
                name: "II_e",
                table: "RTEJs",
                newName: "II_8");

            migrationBuilder.RenameColumn(
                name: "II_d",
                table: "RTEJs",
                newName: "II_7");

            migrationBuilder.RenameColumn(
                name: "II_c",
                table: "RTEJs",
                newName: "II_6");

            migrationBuilder.RenameColumn(
                name: "II_b",
                table: "RTEJs",
                newName: "II_11");

            migrationBuilder.RenameColumn(
                name: "II_a",
                table: "RTEJs",
                newName: "II_10");

            migrationBuilder.RenameColumn(
                name: "III_e",
                table: "RTEJs",
                newName: "III_16");

            migrationBuilder.RenameColumn(
                name: "III_d",
                table: "RTEJs",
                newName: "III_15");

            migrationBuilder.RenameColumn(
                name: "III_c",
                table: "RTEJs",
                newName: "III_14");

            migrationBuilder.RenameColumn(
                name: "III_b",
                table: "RTEJs",
                newName: "III_13");

            migrationBuilder.RenameColumn(
                name: "III_a",
                table: "RTEJs",
                newName: "III_12");
        }
    }
}
