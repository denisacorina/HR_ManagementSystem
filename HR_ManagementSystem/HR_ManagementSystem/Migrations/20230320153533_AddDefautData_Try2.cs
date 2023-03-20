using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_ManagementSystem.Migrations
{
    public partial class AddDefautData_Try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "HireDate", "PersonalInfoID" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 35, 33, 176, DateTimeKind.Local).AddTicks(1701), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "HireDate", "PersonalInfoID" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 30, 14, 573, DateTimeKind.Local).AddTicks(9955), null });
        }
    }
}
