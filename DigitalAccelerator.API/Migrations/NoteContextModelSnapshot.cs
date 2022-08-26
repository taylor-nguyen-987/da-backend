﻿// <auto-generated />
using DigitalAccelerator.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigitalAccelerator.API.Migrations
{
    [DbContext(typeof(NoteContext))]
    partial class NoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DigitalAccelerator.API.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Content")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Megan",
                            Content = "Test Note Content 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Taylor",
                            Content = "Test Note Content 2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Benito",
                            Content = "Test Note Content 3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Tim",
                            Content = "Test Note Content 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}