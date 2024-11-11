using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEmployeeDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemValue",
                table: "InventoryItems",
                newName: "ItemUnitsAvailable");

            migrationBuilder.AddColumn<int>(
                name: "ItemPrice",
                table: "InventoryItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "InventoryItems");

            migrationBuilder.RenameColumn(
                name: "ItemUnitsAvailable",
                table: "InventoryItems",
                newName: "ItemValue");
        }
    }
}
