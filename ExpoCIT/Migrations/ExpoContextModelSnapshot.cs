﻿// <auto-generated />
using System;
using ExpoCIT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpoCIT.Migrations
{
    [DbContext(typeof(ExpoContext))]
    partial class ExpoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExpoCIT.Models.Juez", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Jueces");
                });

            modelBuilder.Entity("ExpoCIT.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Integrantes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JuezId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumStand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoProyecto")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("JuezId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("ExpoCIT.Models.RPEI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FirmaDigital")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("III_a")
                        .HasColumnType("int");

                    b.Property<string>("III_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_b")
                        .HasColumnType("int");

                    b.Property<string>("III_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_c")
                        .HasColumnType("int");

                    b.Property<string>("III_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_d")
                        .HasColumnType("int");

                    b.Property<string>("III_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_e")
                        .HasColumnType("int");

                    b.Property<string>("III_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("II_a")
                        .HasColumnType("int");

                    b.Property<string>("II_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_b")
                        .HasColumnType("int");

                    b.Property<string>("II_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_c")
                        .HasColumnType("int");

                    b.Property<string>("II_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_d")
                        .HasColumnType("int");

                    b.Property<string>("II_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_e")
                        .HasColumnType("int");

                    b.Property<string>("II_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_f")
                        .HasColumnType("int");

                    b.Property<string>("II_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("IV_a")
                        .HasColumnType("int");

                    b.Property<string>("IV_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_b")
                        .HasColumnType("int");

                    b.Property<string>("IV_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_c")
                        .HasColumnType("int");

                    b.Property<string>("IV_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_d")
                        .HasColumnType("int");

                    b.Property<string>("IV_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_e")
                        .HasColumnType("int");

                    b.Property<string>("IV_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_f")
                        .HasColumnType("int");

                    b.Property<string>("IV_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("I_a")
                        .HasColumnType("int");

                    b.Property<string>("I_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_b")
                        .HasColumnType("int");

                    b.Property<string>("I_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_c")
                        .HasColumnType("int");

                    b.Property<string>("I_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_d")
                        .HasColumnType("int");

                    b.Property<string>("I_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_e")
                        .HasColumnType("int");

                    b.Property<string>("I_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("VIII_a")
                        .HasColumnType("int");

                    b.Property<string>("VIII_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_b")
                        .HasColumnType("int");

                    b.Property<string>("VIII_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_c")
                        .HasColumnType("int");

                    b.Property<string>("VIII_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_d")
                        .HasColumnType("int");

                    b.Property<string>("VIII_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("VII_a")
                        .HasColumnType("int");

                    b.Property<string>("VII_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_b")
                        .HasColumnType("int");

                    b.Property<string>("VII_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_c")
                        .HasColumnType("int");

                    b.Property<string>("VII_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_d")
                        .HasColumnType("int");

                    b.Property<string>("VII_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_e")
                        .HasColumnType("int");

                    b.Property<string>("VII_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_f")
                        .HasColumnType("int");

                    b.Property<string>("VII_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("VI_a")
                        .HasColumnType("int");

                    b.Property<string>("VI_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_b")
                        .HasColumnType("int");

                    b.Property<string>("VI_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_c")
                        .HasColumnType("int");

                    b.Property<string>("VI_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_d")
                        .HasColumnType("int");

                    b.Property<string>("VI_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_e")
                        .HasColumnType("int");

                    b.Property<string>("VI_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_f")
                        .HasColumnType("int");

                    b.Property<string>("VI_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_g")
                        .HasColumnType("int");

                    b.Property<string>("VI_g_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_h")
                        .HasColumnType("int");

                    b.Property<string>("VI_h_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("V_a")
                        .HasColumnType("int");

                    b.Property<string>("V_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_b")
                        .HasColumnType("int");

                    b.Property<string>("V_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_c")
                        .HasColumnType("int");

                    b.Property<string>("V_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_d")
                        .HasColumnType("int");

                    b.Property<string>("V_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_e")
                        .HasColumnType("int");

                    b.Property<string>("V_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_f")
                        .HasColumnType("int");

                    b.Property<string>("V_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_subtotal")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("RPEIs");
                });

            modelBuilder.Entity("ExpoCIT.Models.RPEJ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FirmaDigital")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("III_12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("III_13")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("III_14")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("III_15")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("III_16")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("III_subtotal")
                        .HasColumnType("float");

                    b.Property<string>("II_10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("II_11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("II_6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("II_7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("II_8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("II_9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("II_subtotal")
                        .HasColumnType("float");

                    b.Property<string>("IV_17")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IV_18")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IV_19")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IV_20")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IV_21")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IV_22")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IV_subtotal")
                        .HasColumnType("float");

                    b.Property<string>("I_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("I_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("I_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("I_4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("I_5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("I_subtotal")
                        .HasColumnType("float");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<string>("VII_32")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VII_33")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VII_34")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VII_35")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VII_subtotal")
                        .HasColumnType("float");

                    b.Property<string>("VI_28")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VI_29")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VI_30")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VI_31")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VI_subtotal")
                        .HasColumnType("float");

                    b.Property<string>("V_23")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_24")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_25")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_26")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_27")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("V_subtotal")
                        .HasColumnType("float");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("RTEJs");
                });

            modelBuilder.Entity("ExpoCIT.Models.RTEEI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FirmaDigital")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("III_a")
                        .HasColumnType("int");

                    b.Property<string>("III_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_b")
                        .HasColumnType("int");

                    b.Property<string>("III_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_c")
                        .HasColumnType("int");

                    b.Property<string>("III_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_d")
                        .HasColumnType("int");

                    b.Property<string>("III_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("III_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("II_a")
                        .HasColumnType("int");

                    b.Property<string>("II_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_b")
                        .HasColumnType("int");

                    b.Property<string>("II_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_c")
                        .HasColumnType("int");

                    b.Property<string>("II_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_d")
                        .HasColumnType("int");

                    b.Property<string>("II_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_e")
                        .HasColumnType("int");

                    b.Property<string>("II_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_f")
                        .HasColumnType("int");

                    b.Property<string>("II_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("II_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("IV_a")
                        .HasColumnType("int");

                    b.Property<string>("IV_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_b")
                        .HasColumnType("int");

                    b.Property<string>("IV_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_c")
                        .HasColumnType("int");

                    b.Property<string>("IV_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_d")
                        .HasColumnType("int");

                    b.Property<string>("IV_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_e")
                        .HasColumnType("int");

                    b.Property<string>("IV_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IV_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("I_a")
                        .HasColumnType("int");

                    b.Property<string>("I_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_b")
                        .HasColumnType("int");

                    b.Property<string>("I_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_c")
                        .HasColumnType("int");

                    b.Property<string>("I_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_d")
                        .HasColumnType("int");

                    b.Property<string>("I_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_e")
                        .HasColumnType("int");

                    b.Property<string>("I_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("I_subtotal")
                        .HasColumnType("int");

                    b.Property<string>("P_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_13")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("VIII_a")
                        .HasColumnType("int");

                    b.Property<string>("VIII_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_b")
                        .HasColumnType("int");

                    b.Property<string>("VIII_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_c")
                        .HasColumnType("int");

                    b.Property<string>("VIII_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_d")
                        .HasColumnType("int");

                    b.Property<string>("VIII_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_e")
                        .HasColumnType("int");

                    b.Property<string>("VIII_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIII_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("VII_a")
                        .HasColumnType("int");

                    b.Property<string>("VII_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_b")
                        .HasColumnType("int");

                    b.Property<string>("VII_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_c")
                        .HasColumnType("int");

                    b.Property<string>("VII_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_d")
                        .HasColumnType("int");

                    b.Property<string>("VII_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_e")
                        .HasColumnType("int");

                    b.Property<string>("VII_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VII_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("VI_a")
                        .HasColumnType("int");

                    b.Property<string>("VI_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_b")
                        .HasColumnType("int");

                    b.Property<string>("VI_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_c")
                        .HasColumnType("int");

                    b.Property<string>("VI_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_d")
                        .HasColumnType("int");

                    b.Property<string>("VI_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_e")
                        .HasColumnType("int");

                    b.Property<string>("VI_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_f")
                        .HasColumnType("int");

                    b.Property<string>("VI_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VI_subtotal")
                        .HasColumnType("int");

                    b.Property<int>("V_a")
                        .HasColumnType("int");

                    b.Property<string>("V_a_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_b")
                        .HasColumnType("int");

                    b.Property<string>("V_b_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_c")
                        .HasColumnType("int");

                    b.Property<string>("V_c_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_d")
                        .HasColumnType("int");

                    b.Property<string>("V_d_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_e")
                        .HasColumnType("int");

                    b.Property<string>("V_e_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_f")
                        .HasColumnType("int");

                    b.Property<string>("V_f_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("V_subtotal")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("RTEIs");
                });

            modelBuilder.Entity("ExpoCIT.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ExpoCIT.Models.Proyecto", b =>
                {
                    b.HasOne("ExpoCIT.Models.Juez", "Juez")
                        .WithMany("Proyectos")
                        .HasForeignKey("JuezId");

                    b.Navigation("Juez");
                });

            modelBuilder.Entity("ExpoCIT.Models.RPEI", b =>
                {
                    b.HasOne("ExpoCIT.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ExpoCIT.Models.RPEJ", b =>
                {
                    b.HasOne("ExpoCIT.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ExpoCIT.Models.RTEEI", b =>
                {
                    b.HasOne("ExpoCIT.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ExpoCIT.Models.Juez", b =>
                {
                    b.Navigation("Proyectos");
                });
#pragma warning restore 612, 618
        }
    }
}
