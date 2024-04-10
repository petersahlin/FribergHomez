﻿// <auto-generated />
using System;
using FribergHomez.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FribergHomez.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FribergHomez.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FribergHomez.Models.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presentation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealEstateAgents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("FribergHomez.Models.Municipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("FribergHomez.Models.RealEstateAgent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Realtors");
                });

            modelBuilder.Entity("FribergHomez.Models.SaleObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AncillaryArea")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LivingArea")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyFee")
                        .HasColumnType("int");

                    b.Property<int>("MunicipalityId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("OperatingCostPerYear")
                        .HasColumnType("int");

                    b.Property<int>("PlotArea")
                        .HasColumnType("int");

                    b.Property<int?>("RealEstateAgentId")
                        .HasColumnType("int");

                    b.Property<int>("StartingPrice")
                        .HasColumnType("int");

                    b.Property<int>("YearOfConstruction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FirmId");

                    b.HasIndex("MunicipalityId");

                    b.HasIndex("RealEstateAgentId");

                    b.ToTable("SaleObjects");
                });

            modelBuilder.Entity("FribergHomez.Models.RealEstateAgent", b =>
                {
                    b.HasOne("FribergHomez.Models.Firm", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("FribergHomez.Models.SaleObject", b =>
                {
                    b.HasOne("FribergHomez.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FribergHomez.Models.Firm", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FribergHomez.Models.Municipality", "Municipality")
                        .WithMany("SaleObjects")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FribergHomez.Models.RealEstateAgent", null)
                        .WithMany("SaleObjects")
                        .HasForeignKey("RealEstateAgentId");

                    b.Navigation("Category");

                    b.Navigation("Firm");

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("FribergHomez.Models.Municipality", b =>
                {
                    b.Navigation("SaleObjects");
                });

            modelBuilder.Entity("FribergHomez.Models.RealEstateAgent", b =>
                {
                    b.Navigation("SaleObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
