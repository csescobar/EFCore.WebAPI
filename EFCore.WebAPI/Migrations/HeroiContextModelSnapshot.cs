﻿// <auto-generated />
using System;
using EFCore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.WebAPI.Migrations
{
    [DbContext(typeof(HeroiContext))]
    partial class HeroiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.WebAPI.Data.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId")
                        .HasColumnType("int");

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroiBatalhas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.Property<string>("NomeReal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IdentidadeSecretas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Data.HeroiBatalha", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Batalha", "Batalha")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.WebAPI.Models.Heroi", "Heroi")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batalha");

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Arma", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.IdentidadeSecreta", b =>
                {
                    b.HasOne("EFCore.WebAPI.Models.Heroi", "Heroi")
                        .WithOne("IdentidadeSecreta")
                        .HasForeignKey("EFCore.WebAPI.Models.IdentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Batalha", b =>
                {
                    b.Navigation("HeroisBatalhas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Models.Heroi", b =>
                {
                    b.Navigation("Armas");

                    b.Navigation("HeroisBatalhas");

                    b.Navigation("IdentidadeSecreta");
                });
#pragma warning restore 612, 618
        }
    }
}
