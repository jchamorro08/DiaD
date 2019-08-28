﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DayD.Models;

namespace DayD.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190828130154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ejercicio_nuevo.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("ProductId");

                    b.Property<string>("Title");

                    b.HasKey("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ejercicio_nuevo.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.Property<string>("userName");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ejercicio_nuevo.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Other");

                    b.Property<int>("Precio");

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ejercicio_nuevo.Models.Category", b =>
                {
                    b.HasOne("ejercicio_nuevo.Models.Product", "Product")
                        .WithMany("Category")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}