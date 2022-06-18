﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_api.Contexts;

#nullable disable

namespace project_api.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("project_api.Entities.Accounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("project_api.Entities.Addresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("MainAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("project_api.Entities.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Population")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("project_api.Entities.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Continent")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("project_api.Entities.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("project_api.Entities.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrolmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FacultyNumber")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UniversitiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UniversitiesId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("project_api.Entities.StudentsSubjects", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Grade")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("StudentsId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("StudentsSubjects");
                });

            modelBuilder.Entity("project_api.Entities.Subjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("project_api.Entities.Teachers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UniversitiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UniversitiesId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("project_api.Entities.TeachersDepartments", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("TeachersId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("DepartmentsId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("TeachersDepartments");
                });

            modelBuilder.Entity("project_api.Entities.Universities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("project_api.Entities.Addresses", b =>
                {
                    b.HasOne("project_api.Entities.Cities", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("project_api.Entities.Cities", b =>
                {
                    b.HasOne("project_api.Entities.Countries", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("project_api.Entities.Departments", b =>
                {
                    b.HasOne("project_api.Entities.Universities", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("project_api.Entities.Students", b =>
                {
                    b.HasOne("project_api.Entities.Addresses", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_api.Entities.Departments", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_api.Entities.Universities", "Universities")
                        .WithMany()
                        .HasForeignKey("UniversitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Department");

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("project_api.Entities.StudentsSubjects", b =>
                {
                    b.HasOne("project_api.Entities.Students", "Student")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_api.Entities.Subjects", "Subject")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("project_api.Entities.Subjects", b =>
                {
                    b.HasOne("project_api.Entities.Departments", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("project_api.Entities.Teachers", b =>
                {
                    b.HasOne("project_api.Entities.Addresses", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_api.Entities.Universities", "Universities")
                        .WithMany()
                        .HasForeignKey("UniversitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("project_api.Entities.TeachersDepartments", b =>
                {
                    b.HasOne("project_api.Entities.Departments", "Department")
                        .WithMany("TeachersDepartments")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_api.Entities.Teachers", "Teacher")
                        .WithMany("TeachersDepartments")
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("project_api.Entities.Universities", b =>
                {
                    b.HasOne("project_api.Entities.Addresses", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("project_api.Entities.Departments", b =>
                {
                    b.Navigation("TeachersDepartments");
                });

            modelBuilder.Entity("project_api.Entities.Students", b =>
                {
                    b.Navigation("StudentsSubjects");
                });

            modelBuilder.Entity("project_api.Entities.Subjects", b =>
                {
                    b.Navigation("StudentsSubjects");
                });

            modelBuilder.Entity("project_api.Entities.Teachers", b =>
                {
                    b.Navigation("TeachersDepartments");
                });
#pragma warning restore 612, 618
        }
    }
}
