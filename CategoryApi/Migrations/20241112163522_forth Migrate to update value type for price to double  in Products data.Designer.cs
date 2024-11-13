﻿// <auto-generated />
using CategoryApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CategoryApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241112163522_forth Migrate to update value type for price to double  in Products data")]
    partial class forthMigratetoupdatevaluetypeforpricetodoubleinProductsdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bánh kem, bánh kem bắp, bánh kem nhân mứt",
                            Name = "Bánh kem"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bánh mì, bánh quy, donut",
                            Name = "Bánh nướng"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bánh flan, bánh su kem, pudding ",
                            Name = "Bánh lạnh"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Kem vani, kem đậu xanh, kem dâu, kem chuối",
                            Name = "Cà rem"
                        });
                });

            modelBuilder.Entity("CategoryApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Images = "/images/cakes/Banh-Kem-Dau-1.jpg",
                            Name = "Bánh kem nhân dâu",
                            Price = 335000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Images = "/images/cakes/Banh-Kem-Bap-1-2.jpg",
                            Name = "Bánh kem bắp",
                            Price = 335000
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Images = "/images/cakes/Banh-Kem-Thom-10-1.jpg",
                            Name = "Bánh kem nhân mứt",
                            Price = 335000
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Images = "/images/baked-cakes/sandwich-ngu-coc.jpg",
                            Name = "Bánh mì",
                            Price = 23000
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Images = "/images/baked-cakes/Quy-Bo-Dau-Phong.jpg",
                            Name = "Bánh quy",
                            Price = 25000
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Images = "/images/baked-cakes/Banh-Donut.jpg",
                            Name = "Bánh donut",
                            Price = 15000
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Images = "/images/cold-cakes/Banh-Flan-2.jpg",
                            Name = "Bánh flan",
                            Price = 12000
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Images = "/images/cold-cakes/banh_su_kem.jpg",
                            Name = "Bánh su kem",
                            Price = 33000
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Images = "/images/cold-cakes/pudding-xoai.jpg",
                            Name = "Pudding",
                            Price = 35000
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Images = "/images/ice-cream/Kem-Vani.jpg",
                            Name = "Kem vani",
                            Price = 13000
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Images = "/images/ice-cream/Kem-Dau-Xanh.jpg",
                            Name = "Kem đậu xanh",
                            Price = 13000
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Images = "/images/ice-cream/Kem-Dau.jpg",
                            Name = "Kem dâu",
                            Price = 13000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
