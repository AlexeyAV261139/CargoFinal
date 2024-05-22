using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_DifficultyClasses_DifficultyClassId",
                table: "Driver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("2bb31ee6-7e26-426c-8884-060df781464b"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("5591899d-6f9d-4348-b9b1-77ea35e752c2"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("a64c02e2-44f3-429b-98a3-8c839c470eb1"));

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_DifficultyClassId",
                table: "Drivers",
                newName: "IX_Drivers_DifficultyClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8d273827-3f87-4175-9afd-1997575ba2d8"), "1" },
                    { new Guid("e79dad01-38b2-4a3e-8d65-50e54d530bd7"), "3" },
                    { new Guid("e88db540-3786-4a19-9626-27113dc4a5ee"), "2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_DifficultyClasses_DifficultyClassId",
                table: "Drivers",
                column: "DifficultyClassId",
                principalTable: "DifficultyClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_DifficultyClasses_DifficultyClassId",
                table: "Drivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("8d273827-3f87-4175-9afd-1997575ba2d8"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("e79dad01-38b2-4a3e-8d65-50e54d530bd7"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("e88db540-3786-4a19-9626-27113dc4a5ee"));

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Driver");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_DifficultyClassId",
                table: "Driver",
                newName: "IX_Driver_DifficultyClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2bb31ee6-7e26-426c-8884-060df781464b"), "3" },
                    { new Guid("5591899d-6f9d-4348-b9b1-77ea35e752c2"), "2" },
                    { new Guid("a64c02e2-44f3-429b-98a3-8c839c470eb1"), "1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_DifficultyClasses_DifficultyClassId",
                table: "Driver",
                column: "DifficultyClassId",
                principalTable: "DifficultyClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
