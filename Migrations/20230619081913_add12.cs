using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class add12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_user_UserId",
                table: "order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.AddForeignKey(
                name: "FK_order_user_UserId",
                table: "order",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_user_UserId",
                table: "order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(96),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(2146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(9012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 65, DateTimeKind.Utc).AddTicks(1000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(8848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 15, 9, 8, 64, DateTimeKind.Utc).AddTicks(8675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 19, 8, 19, 13, 754, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.AddForeignKey(
                name: "FK_order_user_UserId",
                table: "order",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
