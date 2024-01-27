using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyApp.Context.Migrations
{
    /// <inheritdoc />
    public partial class pharmacymedicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserIdId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserIdId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameColumn(
                name: "NumberOfOrder",
                table: "Medicincs",
                newName: "Tapes");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Medicincs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionDate",
                table: "Medicincs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Medicincs");

            migrationBuilder.DropColumn(
                name: "ProductionDate",
                table: "Medicincs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_UserIdId");

            migrationBuilder.RenameColumn(
                name: "Tapes",
                table: "Medicincs",
                newName: "NumberOfOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserIdId",
                table: "Orders",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
