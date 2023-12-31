﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using at_test.Data;

#nullable disable

namespace at_test.Migrations
{
    [DbContext(typeof(EsportivaContext))]
    [Migration("20231205221443_AddPropDataRegistro")]
    partial class AddPropDataRegistro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("at_test.Data.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "41741808065",
                            DataCadastro = new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1998, 12, 5, 5, 46, 32, 0, DateTimeKind.Unspecified),
                            Nome = "Marcos Ramos"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "66639368080",
                            DataCadastro = new DateTime(2021, 3, 2, 21, 12, 19, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1987, 10, 7, 9, 26, 36, 0, DateTimeKind.Unspecified),
                            Nome = "Carlos Augusto"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "88846663098",
                            DataCadastro = new DateTime(2022, 9, 13, 13, 42, 25, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(2002, 9, 12, 12, 20, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Gabriel Carvalho"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "45061531035",
                            DataCadastro = new DateTime(2023, 1, 8, 10, 12, 58, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1973, 4, 4, 22, 49, 14, 0, DateTimeKind.Unspecified),
                            Nome = "Abel Ferreira"
                        });
                });

            modelBuilder.Entity("at_test.Data.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Areia lavada Saco 1KG",
                            Nome = "Areia Lavada Saco 1KG",
                            NomeImagem = "areia.png",
                            Preco = 2.90m,
                            Quantidade = 500
                        },
                        new
                        {
                            Id = 2,
                            DataRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Saco cimento votoram 25KG",
                            Nome = "Cimento Votoram 25KG",
                            NomeImagem = "cimento_votoram.png",
                            Preco = 27.90m,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 3,
                            DataRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Tijolo Tradicional",
                            Nome = "Tijolo Tradicional",
                            NomeImagem = "tijolo.png",
                            Preco = 4.90m,
                            Quantidade = 400
                        },
                        new
                        {
                            Id = 4,
                            DataRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Tubo Esgoto PVC Série Normal 6M",
                            Nome = "Tubo Esgoto PVC Série Normal 6M",
                            NomeImagem = "tubo_esgoto_pvc_6m.png",
                            Preco = 5.90m,
                            Quantidade = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
