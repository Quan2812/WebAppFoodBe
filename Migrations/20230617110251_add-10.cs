using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class add10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.AddColumn<string>(
                name: "fullDescription",
                table: "product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "shortDescription",
                table: "product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(1728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(2959));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullDescription",
                table: "product");

            migrationBuilder.DropColumn(
                name: "shortDescription",
                table: "product");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Reservation_details_service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product_image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(4175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImagePages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(3141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 16, 2, 19, 33, 776, DateTimeKind.Utc).AddTicks(2959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 11, 2, 51, 197, DateTimeKind.Utc).AddTicks(1728));
        }
    }
}
