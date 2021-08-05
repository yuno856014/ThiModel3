﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentMagament.DBContextts;

namespace StudentMagament.Migrations
{
    [DbContext(typeof(StudentMagamentDBContext))]
    [Migration("20210805023336_CreateStudentManagement")]
    partial class CreateStudentManagement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentMagament.Entities.ClassRoom", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("ClassRooms");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "Toan Hoc"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "Sinh Hoc"
                        });
                });

            modelBuilder.Entity("StudentMagament.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("DateOfBirth")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int?>("classRoomClassId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("classRoomClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassId = 2,
                            DateOfBirth = 2000,
                            Email = "duy.tran@gmail.com",
                            Gender = true,
                            StudentName = "Duy Tran"
                        },
                        new
                        {
                            StudentId = 2,
                            ClassId = 1,
                            DateOfBirth = 1999,
                            Email = "thanh.ho@gmail.com",
                            Gender = true,
                            StudentName = "Thanh Ho"
                        });
                });

            modelBuilder.Entity("StudentMagament.Entities.Student", b =>
                {
                    b.HasOne("StudentMagament.Entities.ClassRoom", "classRoom")
                        .WithMany()
                        .HasForeignKey("classRoomClassId");
                });
#pragma warning restore 612, 618
        }
    }
}