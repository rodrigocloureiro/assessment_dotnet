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
    [Migration("20231209035148_UpdateDataSeedingProdutos")]
    partial class UpdateDataSeedingProdutos
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
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

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
                            Id = 10,
                            DataRegistro = new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Vasco Branca III (Edição Especial) 2022/2023 – Versão Torcedor",
                            Nome = "Camisa Vasco Branca III 2022/2023",
                            NomeImagem = "camisa_vasco_III.png",
                            Preco = 359.90m,
                            Quantidade = 500
                        },
                        new
                        {
                            Id = 11,
                            DataRegistro = new DateTime(2022, 7, 29, 15, 36, 12, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Vasco Preta III (Goleiro - Edição Especial) 2022/2023 – Todos os Patrocinadores – Versão Torcedor",
                            Nome = "Camisa Vasco Preta III (Goleiro) 2022/2023",
                            NomeImagem = "camisa_vasco_III_goleiro.png",
                            Preco = 359.90m,
                            Quantidade = 450
                        },
                        new
                        {
                            Id = 12,
                            DataRegistro = new DateTime(2023, 9, 25, 11, 17, 25, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Vasco III Branco – (Goleiro) 2023/2024 – Versão Torcedor",
                            Nome = "Camisa Vasco III Branco – (Goleiro) 2023/2024",
                            NomeImagem = "camisa_vasco_branco_goleiro_2023_2024.png",
                            Preco = 329.90m,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 13,
                            DataRegistro = new DateTime(2023, 7, 12, 13, 34, 46, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Vasco Azul Claro – (Goleiro) 2023/2024 – Versão Torcedor",
                            Nome = "Camisa Vasco Azul Claro – (Goleiro) 2023/2024",
                            NomeImagem = "camisa_vasco_goleiro_azul_claro_2023_2024.png",
                            Preco = 299.90m,
                            Quantidade = 390
                        },
                        new
                        {
                            Id = 14,
                            DataRegistro = new DateTime(2023, 8, 15, 10, 0, 5, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Al Nassr Home 2023/2024 – Versão Torcedor",
                            Nome = "Camisa Al Nassr Home 2023/2024",
                            NomeImagem = "camisa_al_nassr_home_2023_2024.png",
                            Preco = 299.90m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 15,
                            DataRegistro = new DateTime(2023, 8, 15, 10, 0, 5, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Al Nassr Away 2023/2024 – Versão Torcedor",
                            Nome = "Camisa Al Nassr Away 2023/2024",
                            NomeImagem = "camisa_al_nassr_away_2023_2024.png",
                            Preco = 299.90m,
                            Quantidade = 70
                        },
                        new
                        {
                            Id = 16,
                            DataRegistro = new DateTime(2023, 8, 15, 10, 30, 5, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Benfica Away 2023/2024 – Versão Torcedor",
                            Nome = "Camisa Benfica Away 2023/2024",
                            NomeImagem = "camisa_benfica_away_2023_2024.png",
                            Preco = 299.90m,
                            Quantidade = 90
                        },
                        new
                        {
                            Id = 17,
                            DataRegistro = new DateTime(2023, 9, 17, 17, 2, 25, 0, DateTimeKind.Unspecified),
                            Descricao = "Camisa Manchester United (Goleiro) 2023/2024 Verde – Versão Torcedor",
                            Nome = "Camisa Manchester United Verde (Goleiro) 2023/2024",
                            NomeImagem = "camisa_manchester_united_goleiro_2023_2024_verde.png",
                            Preco = 299.90m,
                            Quantidade = 50
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
