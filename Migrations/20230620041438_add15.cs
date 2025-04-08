using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class add15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(5003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.AddColumn<string>(
                name: "noteOrder",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    voucherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valuevoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(5099)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(5217))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.voucherId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropColumn(
                name: "noteOrder",
                table: "order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(9081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(1095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 279, DateTimeKind.Utc).AddTicks(23),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 12, 28, 34, 278, DateTimeKind.Utc).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 20, 4, 14, 38, 75, DateTimeKind.Utc).AddTicks(1679));
        }
    }
}
