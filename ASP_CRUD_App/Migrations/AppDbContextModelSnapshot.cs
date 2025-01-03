﻿// <auto-generated />
using ASP_CRUD_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_CRUD_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_CRUD_App.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            CarImage = "ford_galaxy_2008.jpg",
                            CategoryId = "Van",
                            Color = "Red",
                            Make = "Ford",
                            Model = "Galaxy",
                            Price = 49.99m,
                            Rating = 3,
                            Year = 2008
                        },
                        new
                        {
                            CarId = 2,
                            CarImage = "honda_civic_2006.jpg",
                            CategoryId = "Sedan",
                            Color = "Charcoal",
                            Make = "Honda",
                            Model = "Civic",
                            Price = 39.99m,
                            Rating = 5,
                            Year = 2006
                        },
                        new
                        {
                            CarId = 3,
                            CarImage = "toyota_landcruiser100_2005.jpg",
                            CategoryId = "SUV",
                            Color = "Green",
                            Make = "Toyota",
                            Model = "Landcruiser",
                            Price = 42.99m,
                            Rating = 5,
                            Year = 2005
                        },
                        new
                        {
                            CarId = 4,
                            CarImage = "vw_golf_2008.jpg",
                            CategoryId = "Hatchback",
                            Color = "Silver",
                            Make = "VW",
                            Model = "Golf",
                            Price = 65.99m,
                            Rating = 2,
                            Year = 2008
                        },
                        new
                        {
                            CarId = 5,
                            CarImage = "lincoln_towncar_2006.jpg",
                            CategoryId = "Limousine",
                            Color = "White",
                            Make = "Lincoln",
                            Model = "Towncar",
                            Price = 105.99m,
                            Rating = 4,
                            Year = 2006
                        });
                });

            modelBuilder.Entity("ASP_CRUD_App.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "Sedan",
                            CategoryName = "Sedan",
                            ImageName = "Sedan.png"
                        },
                        new
                        {
                            CategoryId = "Hatchback",
                            CategoryName = "Hatchback",
                            ImageName = "Hatchback.png"
                        },
                        new
                        {
                            CategoryId = "SUV",
                            CategoryName = "SUV",
                            ImageName = "SUV.png"
                        },
                        new
                        {
                            CategoryId = "Limousine",
                            CategoryName = "Limousine",
                            ImageName = "Limousine.png"
                        },
                        new
                        {
                            CategoryId = "Van",
                            CategoryName = "Van",
                            ImageName = "Van.png"
                        });
                });

            modelBuilder.Entity("ASP_CRUD_App.Models.Car", b =>
                {
                    b.HasOne("ASP_CRUD_App.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}