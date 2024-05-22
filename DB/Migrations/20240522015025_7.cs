using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    LoadCapacityKg = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8d55b9ad-2499-4a3d-8600-60b5cf292007"), "1" },
                    { new Guid("bb2fdd63-5593-4209-beaf-313e6dc953ae"), "2" },
                    { new Guid("c2db01e9-9d77-4b4c-b217-8182fced6a0a"), "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("8d55b9ad-2499-4a3d-8600-60b5cf292007"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("bb2fdd63-5593-4209-beaf-313e6dc953ae"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("c2db01e9-9d77-4b4c-b217-8182fced6a0a"));

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8d273827-3f87-4175-9afd-1997575ba2d8"), "1" },
                    { new Guid("e79dad01-38b2-4a3e-8d65-50e54d530bd7"), "3" },
                    { new Guid("e88db540-3786-4a19-9626-27113dc4a5ee"), "2" }
                });
        }
    }
}
