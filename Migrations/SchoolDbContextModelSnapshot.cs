﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppSample.Models;

namespace WebAppSample.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppSample.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Established")
                        .HasColumnType("datetime2");

                    b.Property<bool>("GovtApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBoarding")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReligious")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfStudents")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfTeachers")
                        .HasColumnType("int");

                    b.Property<string>("PrincipalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolWeb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            SchoolId = 1,
                            Established = new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GovtApproved = true,
                            IsBoarding = false,
                            IsReligious = false,
                            NumberOfStudents = 340,
                            NumberOfTeachers = 32,
                            PrincipalName = "Mr O.O Obajimi",
                            SchoolAddress = "1, Obajimi Close, Ikosi",
                            SchoolCity = "Ketu",
                            SchoolEmail = "owosamsonschool@outlook.com",
                            SchoolName = "Owo-Samson Memorial School",
                            SchoolPhone = "08090322312",
                            SchoolState = "Lagos"
                        },
                        new
                        {
                            SchoolId = 2,
                            Established = new DateTime(1971, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GovtApproved = true,
                            IsBoarding = false,
                            IsReligious = false,
                            NumberOfStudents = 210,
                            NumberOfTeachers = 35,
                            PrincipalName = "Mrs Atinuke Lawal",
                            SchoolAddress = "10, Lawanson Avenue,",
                            SchoolCity = "Surulere",
                            SchoolEmail = "yewandeschool@aol.com",
                            SchoolName = "Yewande Memorial School",
                            SchoolPhone = "08023886558",
                            SchoolState = "Lagos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
