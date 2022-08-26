﻿// <auto-generated />
using InfoCelEletronic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfoCelEletronic.Migrations
{
    [DbContext(typeof(infoceleletronicContext))]
    [Migration("20220802170820_CreateDatabaseFKclienteServico2")]
    partial class CreateDatabaseFKclienteServico2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InfoCelEletronic.Models.cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nomeUsuario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("clientedb");
                });

            modelBuilder.Entity("InfoCelEletronic.Models.servicos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoriaserv")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("nomedoservico")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("quantidadeserv")
                        .HasColumnType("int");

                    b.Property<double>("valortotal")
                        .HasColumnType("double");

                    b.Property<double>("valorunitario")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.HasIndex("clienteId");

                    b.ToTable("servicosdb");
                });

            modelBuilder.Entity("InfoCelEletronic.Models.servicos", b =>
                {
                    b.HasOne("InfoCelEletronic.Models.cliente", "cliente")
                        .WithMany("servicos")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
