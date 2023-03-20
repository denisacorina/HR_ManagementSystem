using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_ManagementSystem.Migrations
{
    public partial class AddDefautData_Try1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "HireDate", "IsHr", "ManagerName", "Password", "PersonalInfoID", "ReportId", "TerminationDate" },
                values: new object[] { 1, "employee1@gmail.com", new DateTime(2023, 3, 20, 17, 30, 14, 573, DateTimeKind.Local).AddTicks(9955), false, "Andrei", "ABcd1234", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);
        }
    }
}
