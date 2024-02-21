﻿// <auto-generated />
using System;
using ControleEmpresa.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleEmpresa.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240221155942_dataDeContratacao")]
    partial class dataDeContratacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleEmpresa.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeContratacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("SetorId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Ponto", b =>
                {
                    b.Property<int>("PontoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Entrada")
                        .HasColumnType("time")
                        .HasColumnName("Entrada");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Saida")
                        .HasColumnType("time")
                        .HasColumnName("Saida");

                    b.HasKey("PontoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Pontos");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Setor", b =>
                {
                    b.Property<int>("SetorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("SetorId");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Funcionario", b =>
                {
                    b.HasOne("ControleEmpresa.Models.Setor", "Setor")
                        .WithMany("Funcionarios")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Ponto", b =>
                {
                    b.HasOne("ControleEmpresa.Models.Funcionario", "Funcionario")
                        .WithMany("Pontos")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Funcionario", b =>
                {
                    b.Navigation("Pontos");
                });

            modelBuilder.Entity("ControleEmpresa.Models.Setor", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
