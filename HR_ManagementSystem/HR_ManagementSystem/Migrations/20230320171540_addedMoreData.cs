using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_ManagementSystem.Migrations
{
    public partial class addedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankInfos",
                columns: new[] { "Id", "BankName", "Iban" },
                values: new object[] { 2, "Raiffeisen Bank", "234567654" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 3, 20, 19, 15, 40, 559, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.InsertData(
                table: "PersonalInfos",
                columns: new[] { "Id", "AddressId", "BankInfoId", "CNP", "DateOfBirth", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 2, null, null, "123446775434567", new DateTime(1989, 4, 4, 15, 24, 16, 0, DateTimeKind.Unspecified), "Andreea", "F", "Zyx", "0714345566" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "HireDate", "IsHr", "ManagerName", "Password", "PersonalInfoID", "ReportId", "TerminationDate" },
                values: new object[] { 2, "employee2@gmail.com", new DateTime(2023, 3, 20, 19, 15, 40, 559, DateTimeKind.Local).AddTicks(5118), true, "Denisa", "ABcd1234", 2, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonalInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 3, 20, 18, 37, 18, 126, DateTimeKind.Local).AddTicks(8246));
        }
    }
}
