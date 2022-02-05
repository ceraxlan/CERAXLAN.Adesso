﻿// <auto-generated />
using System;
using CERAXLAN.Adesso.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220205160554_DriverAndPassenger8")]
    partial class DriverAndPassenger8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CERAXLAN.Adesso.Entities.Concrete.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("CERAXLAN.Adesso.Entities.Concrete.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassengerUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelId")
                        .HasColumnType("int");

                    b.HasKey("PassengerId");

                    b.HasIndex("TravelId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("CERAXLAN.Adesso.Entities.Concrete.Travel", b =>
                {
                    b.Property<int>("TravelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentSeatingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxSeatingCapacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToWhere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TravelStatus")
                        .HasColumnType("bit");

                    b.Property<string>("WhereFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TravelId");

                    b.ToTable("Travels");
                });

            modelBuilder.Entity("CERAXLAN.Adesso.Entities.Concrete.Passenger", b =>
                {
                    b.HasOne("CERAXLAN.Adesso.Entities.Concrete.Travel", null)
                        .WithMany("Passengers")
                        .HasForeignKey("TravelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CERAXLAN.Adesso.Entities.Concrete.Travel", b =>
                {
                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
