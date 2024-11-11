using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeSalesPerformanceDetailsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeSalesPerformance",
                columns: table => new
                {
                    SalesId = table.Column<string>(type: "TEXT", nullable: false),
                    EmpId = table.Column<string>(type: "TEXT", nullable: false),
                    SalesCount = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalesPerformance", x => x.SalesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeSalesPerformance");
        }
    }
}
