﻿// <auto-generated />
using CareCare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CareCare.Data.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20250317043045_.")]
    partial class _
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("CareCare.Data.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AmountChargedToCustomer")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Overhead")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalCostOfServices")
                        .HasColumnType("TEXT");

                    b.Property<bool>("VehicleIsDetailed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("VehicleIsTinted")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CareCare.Data.Tinting", b =>
                {
                    b.Property<int>("TintingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("CostOfLightsTint")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("CostOfWindowTint")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HeadlightsAreTinted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TaillightsAreTinted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TintAmount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TintPercent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TintingType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TintingId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Tinting");
                });

            modelBuilder.Entity("CareCare.Data.Tinting", b =>
                {
                    b.HasOne("CareCare.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
