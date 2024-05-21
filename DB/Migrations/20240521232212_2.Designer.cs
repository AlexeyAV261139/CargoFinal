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
    [Migration("20240521232212_2")]
    partial class _2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("DB.CargoEntity", b =>
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

            modelBuilder.Entity("DB.CargoTypeEntity", b =>
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

            modelBuilder.Entity("DB.CargoEntity", b =>
                {
                    b.HasOne("DB.CargoTypeEntity", "CargoType")
                        .WithMany("Entities")
                        .HasForeignKey("CargoTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoType");
                });

            modelBuilder.Entity("DB.CargoTypeEntity", b =>
                {
                    b.Navigation("Entities");
                });
#pragma warning restore 612, 618
        }
    }
}
