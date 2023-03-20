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
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Email = "employee1@gmail.com", Password = "ABcd1234", HireDate = DateTime.Now, TerminationDate = null, ManagerName = "Andrei", IsHr = false  }
                
              );

      
        }


    }
}
