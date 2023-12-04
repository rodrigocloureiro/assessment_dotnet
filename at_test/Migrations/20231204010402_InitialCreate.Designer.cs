﻿// <auto-generated />
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
    [Migration("20231204010402_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("at_test.Data.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeImagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Areia lavada Saco 1KG",
                            Nome = "Areia Lavada Saco 1KG",
                            NomeImagem = "areia.png",
                            Preco = 2.9f,
                            Quantidade = 500
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Saco cimento votoram 25KG",
                            Nome = "Cimento Votoram 25KG",
                            NomeImagem = "cimento_votoram.png",
                            Preco = 27.9f,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Tijolo Tradicional",
                            Nome = "Tijolo Tradicional",
                            NomeImagem = "tijolo.png",
                            Preco = 4.9f,
                            Quantidade = 400
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Tubo Esgoto PVC Série Normal 6M",
                            Nome = "Tubo Esgoto PVC Série Normal 6M",
                            NomeImagem = "tubo_esgoto_pvc_6m.png",
                            Preco = 5.9f,
                            Quantidade = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}