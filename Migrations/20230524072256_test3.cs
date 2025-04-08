using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FOLYFOOD.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_account_AccountId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AccountId",
                table: "user",
                newName: "IX_user_AccountId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 681, DateTimeKind.Utc).AddTicks(9994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 681, DateTimeKind.Utc).AddTicks(9849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_account_AccountId",
                table: "user",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_account_AccountId",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_user_AccountId",
                table: "Users",
                newName: "IX_Users_AccountId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "decentralization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 681, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "account",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 681, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 7, 20, 57, 286, DateTimeKind.Utc).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 24, 7, 22, 56, 682, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_account_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
