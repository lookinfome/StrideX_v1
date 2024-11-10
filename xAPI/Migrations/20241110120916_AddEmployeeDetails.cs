using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<string>(type: "TEXT", nullable: false),
                    EmpPassword = table.Column<string>(type: "TEXT", nullable: false),
                    EmpName = table.Column<string>(type: "TEXT", nullable: false),
                    EmpGender = table.Column<string>(type: "TEXT", nullable: false),
                    EmpPhone = table.Column<string>(type: "TEXT", nullable: false),
                    EmpEmail = table.Column<string>(type: "TEXT", nullable: false),
                    EmpBirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmpJoinDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
