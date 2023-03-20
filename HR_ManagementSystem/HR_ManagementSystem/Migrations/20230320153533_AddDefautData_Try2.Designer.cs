﻿// <auto-generated />
using System;
using HR_ManagementSystem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR_ManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230320153533_AddDefautData_Try2")]
    partial class AddDefautData_Try2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeReport", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("ReportsReportId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeesEmployeeId", "ReportsReportId");

                    b.HasIndex("ReportsReportId");

                    b.ToTable("EmployeeReport");
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.BankInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iban")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankInfos");
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsHr")
                        .HasColumnType("bit");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonalInfoID")
                        .HasColumnType("int");

                    b.Property<int?>("ReportId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PersonalInfoID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "employee1@gmail.com",
                            HireDate = new DateTime(2023, 3, 20, 17, 35, 33, 176, DateTimeKind.Local).AddTicks(1701),
                            IsHr = false,
                            ManagerName = "Andrei",
                            Password = "ABcd1234",
                            PersonalInfoID = 1
                        });
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.PersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("BankInfoId")
                        .HasColumnType("int");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("BankInfoId");

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.Report", b =>
                {
                    b.Property<string>("ReportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("EmployeeReport", b =>
                {
                    b.HasOne("HR_ManagementSystem.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_ManagementSystem.Models.Report", null)
                        .WithMany()
                        .HasForeignKey("ReportsReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.Employee", b =>
                {
                    b.HasOne("HR_ManagementSystem.Models.PersonalInfo", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoID");

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("HR_ManagementSystem.Models.PersonalInfo", b =>
                {
                    b.HasOne("HR_ManagementSystem.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("HR_ManagementSystem.Models.BankInfo", "BankInfo")
                        .WithMany()
                        .HasForeignKey("BankInfoId");

                    b.Navigation("Address");

                    b.Navigation("BankInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
