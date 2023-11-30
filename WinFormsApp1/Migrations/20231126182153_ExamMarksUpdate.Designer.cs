﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1.DbContextStudent;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231126182153_ExamMarksUpdate")]
    partial class ExamMarksUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinFormsApp1.DbContextStudent.ExamMarks", b =>
                {
                    b.Property<int>("StudentNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentNo"), 1L, 1);

                    b.Property<int>("Exam1")
                        .HasColumnType("int");

                    b.Property<int>("Exam2")
                        .HasColumnType("int");

                    b.Property<int>("Exam3")
                        .HasColumnType("int");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentNo");

                    b.ToTable("ExamMarks");
                });

            modelBuilder.Entity("WinFormsApp1.DbContextStudent.Lessons", b =>
                {
                    b.Property<int>("LessonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonID"), 1L, 1);

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("WinFormsApp1.DbContextStudent.Students", b =>
                {
                    b.Property<int>("StudentNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentNo"), 1L, 1);

                    b.Property<string>("StudentImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentNo");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
