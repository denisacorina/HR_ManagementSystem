using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_ManagementSystem.Migrations
{
    public partial class ReportModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReportName",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportName",
                table: "Reports");
        }
    }
}
