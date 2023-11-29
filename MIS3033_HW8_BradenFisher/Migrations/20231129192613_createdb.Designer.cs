﻿// <auto-generated />
using MIS3033_HW8_BradenFisher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MIS3033_HW8_BradenFisher.Migrations
{
    [DbContext(typeof(PatientDB))]
    [Migration("20231129192613_createdb")]
    partial class createdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MIS3033_HW8_BradenFisher.Models.Patient", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<double>("BMI")
                        .HasColumnType("double precision");

                    b.Property<string>("BMILevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<double>("weight")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
