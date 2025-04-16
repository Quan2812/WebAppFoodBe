using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class AddCloumnCodeTableOrderStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "order_status",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "order_status");
        }
    }
}
