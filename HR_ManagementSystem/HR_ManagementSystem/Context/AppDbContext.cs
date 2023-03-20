using HR_ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HR_ManagementSystem.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            AddDefaultData(model);

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<BankInfo> BankInfos { get; set; }
        public DbSet<Report> Reports { get; set; }


        private static void AddDefaultData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankInfo>().HasData(
                new BankInfo { Id = 1, BankName = "Raiffeisen Bank", Iban = "1234566543" }
                );
            
           modelBuilder.Entity<PersonalInfo>().HasData(
                new PersonalInfo 
                { 
                    Id = 1, 
                    FirstName = "Alexandru", 
                    LastName = "Xyz", 
                    PhoneNumber = "0712345566", 
                    Gender = 'M', 
                    CNP = "123456789865434567", 
                    DateOfBirth = new DateTime(1990, 6, 10, 15, 24, 16),
                    BankInfoId = 1
                },
                 new PersonalInfo
                 {
                     Id = 2,
                     FirstName = "Andreea",
                     LastName = "Zyx",
                     PhoneNumber = "0714345566",
                     Gender = 'F',
                     CNP = "123446775434567",
                     DateOfBirth = new DateTime(1989, 4, 4, 15, 24, 16)
                 }
                );
            
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Email = "employee1@gmail.com",
                    Password = "ABcd1234",
                    HireDate = DateTime.Now,
                    ManagerName = "Andrei",
                    IsHr = false,
                    PersonalInfoID = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    Email = "employee2@gmail.com",
                    Password = "ABcd1234",
                    HireDate = DateTime.Now,
                    ManagerName = "Denisa",
                    IsHr = true,
                    PersonalInfoID = 2
                }

              );




        }


    }
}
