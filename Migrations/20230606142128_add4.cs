using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class add4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(234));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "product");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(1463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(3523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 4, 14, 52, 0, 283, DateTimeKind.Utc).AddTicks(234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 14, 21, 28, 58, DateTimeKind.Utc).AddTicks(3274));
        }
    }
}
