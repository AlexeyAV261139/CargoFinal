﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(CargoContext))]
    [Migration("20240522005203_5")]
    partial class _5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("DB.DifficultyClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DifficultyClasses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a64c02e2-44f3-429b-98a3-8c839c470eb1"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("5591899d-6f9d-4348-b9b1-77ea35e752c2"),
                            Name = "2"
                        },
                        new
                        {
                            Id = new Guid("2bb31ee6-7e26-426c-8884-060df781464b"),
                            Name = "3"
                        });
                });

            modelBuilder.Entity("DB.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DifficultyClassId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Patronymic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyClassId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("DB.Models.CargoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CargoTypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CargoTypeId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("DB.Models.CargoTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CargoTypes");
                });

            modelBuilder.Entity("DB.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DifficultyClassId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DistanceKm")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyClassId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("DB.Driver", b =>
                {
                    b.HasOne("DB.DifficultyClass", "DifficultyClass")
                        .WithMany("Drivers")
                        .HasForeignKey("DifficultyClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DifficultyClass");
                });

            modelBuilder.Entity("DB.Models.CargoEntity", b =>
                {
                    b.HasOne("DB.Models.CargoTypeEntity", "CargoType")
                        .WithMany("Entities")
                        .HasForeignKey("CargoTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoType");
                });

            modelBuilder.Entity("DB.Route", b =>
                {
                    b.HasOne("DB.DifficultyClass", "DifficultyClass")
                        .WithMany("Routes")
                        .HasForeignKey("DifficultyClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DifficultyClass");
                });

            modelBuilder.Entity("DB.DifficultyClass", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("Routes");
                });

            modelBuilder.Entity("DB.Models.CargoTypeEntity", b =>
                {
                    b.Navigation("Entities");
                });
#pragma warning restore 612, 618
        }
    }
}
