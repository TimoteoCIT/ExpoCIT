using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpoCIT.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jueces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jueces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumStand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Integrantes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProyecto = table.Column<int>(type: "int", nullable: false),
                    JuezId = table.Column<int>(type: "int", nullable: true),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proyectos_Jueces_JuezId",
                        column: x => x.JuezId,
                        principalTable: "Jueces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RPEIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_subtotal = table.Column<double>(type: "float", nullable: false),
                    II_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_subtotal = table.Column<double>(type: "float", nullable: false),
                    III_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_subtotal = table.Column<double>(type: "float", nullable: false),
                    IV_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_subtotal = table.Column<double>(type: "float", nullable: false),
                    V_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_subtotal = table.Column<double>(type: "float", nullable: false),
                    VI_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_g = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_h = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_subtotal = table.Column<double>(type: "float", nullable: false),
                    VII_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_subtotal = table.Column<double>(type: "float", nullable: false),
                    VIII_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_subtotal = table.Column<double>(type: "float", nullable: false),
                    DG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaDigital = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPEIs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPEIs_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RTEIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_subtotal = table.Column<double>(type: "float", nullable: false),
                    II_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_subtotal = table.Column<double>(type: "float", nullable: false),
                    III_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_subtotal = table.Column<double>(type: "float", nullable: false),
                    IV_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_subtotal = table.Column<double>(type: "float", nullable: false),
                    V_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_subtotal = table.Column<double>(type: "float", nullable: false),
                    VI_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_subtotal = table.Column<double>(type: "float", nullable: false),
                    VII_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_subtotal = table.Column<double>(type: "float", nullable: false),
                    VIII_a = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_b = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_d = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_e = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIII_subtotal = table.Column<double>(type: "float", nullable: false),
                    P_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaDigital = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTEIs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTEIs_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RTEJs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_subtotal = table.Column<double>(type: "float", nullable: false),
                    II_6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    II_subtotal = table.Column<double>(type: "float", nullable: false),
                    III_12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    III_subtotal = table.Column<double>(type: "float", nullable: false),
                    IV_17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV_subtotal = table.Column<double>(type: "float", nullable: false),
                    V_23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_25 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_26 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_27 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    V_subtotal = table.Column<double>(type: "float", nullable: false),
                    VI_28 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_29 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_30 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_31 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VI_subtotal = table.Column<double>(type: "float", nullable: false),
                    VII_32 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_33 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_34 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_35 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VII_subtotal = table.Column<double>(type: "float", nullable: false),
                    DG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaDigital = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTEJs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTEJs_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_JuezId",
                table: "Proyectos",
                column: "JuezId");

            migrationBuilder.CreateIndex(
                name: "IX_RPEIs_ProyectoId",
                table: "RPEIs",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_RTEIs_ProyectoId",
                table: "RTEIs",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_RTEJs_ProyectoId",
                table: "RTEJs",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RPEIs");

            migrationBuilder.DropTable(
                name: "RTEIs");

            migrationBuilder.DropTable(
                name: "RTEJs");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Jueces");
        }
    }
}
