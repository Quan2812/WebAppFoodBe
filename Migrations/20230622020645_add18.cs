using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class add18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Vouchers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Vouchers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(6632));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Vouchers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Vouchers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(8116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(1043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "order",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "order",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(7007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 38, DateTimeKind.Utc).AddTicks(21),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 21, 15, 12, 41, 37, DateTimeKind.Utc).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 22, 2, 6, 45, 42, DateTimeKind.Utc).AddTicks(5125));
        }
    }
}
