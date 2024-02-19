﻿// <auto-generated />
using System;
using ControleEmpresa.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleEmpresa.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleEmpresa.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.HasKey("FuncId");

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

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FuncId")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionarioFuncId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Saida")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PontoId");

                    b.HasIndex("FuncionarioFuncId");

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
                        .HasForeignKey("FuncionarioFuncId");

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
