using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_PaymentOrders_PaymentOrderPaymentId",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentOrders",
                table: "PaymentOrders");

            migrationBuilder.RenameTable(
                name: "PaymentOrders",
                newName: "payment_order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment_order",
                table: "payment_order",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_payment_order_PaymentOrderPaymentId",
                table: "order",
                column: "PaymentOrderPaymentId",
                principalTable: "payment_order",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_payment_order_PaymentOrderPaymentId",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment_order",
                table: "payment_order");

            migrationBuilder.RenameTable(
                name: "payment_order",
                newName: "PaymentOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentOrders",
                table: "PaymentOrders",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_PaymentOrders_PaymentOrderPaymentId",
                table: "order",
                column: "PaymentOrderPaymentId",
                principalTable: "PaymentOrders",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
