using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("3b989cc2-a59c-4af9-a031-6e3df1476fe2"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("4adbb03f-fcd9-4249-ad6a-c2d6a53a687d"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("e3024b38-a6db-4d58-ab22-fd0f88cdd3bc"));

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Patronymic = table.Column<string>(type: "TEXT", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    DifficultyClassId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Driver_DifficultyClasses_DifficultyClassId",
                        column: x => x.DifficultyClassId,
                        principalTable: "DifficultyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2bb31ee6-7e26-426c-8884-060df781464b"), "3" },
                    { new Guid("5591899d-6f9d-4348-b9b1-77ea35e752c2"), "2" },
                    { new Guid("a64c02e2-44f3-429b-98a3-8c839c470eb1"), "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DifficultyClassId",
                table: "Driver",
                column: "DifficultyClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");

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

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b989cc2-a59c-4af9-a031-6e3df1476fe2"), "2" },
                    { new Guid("4adbb03f-fcd9-4249-ad6a-c2d6a53a687d"), "1" },
                    { new Guid("e3024b38-a6db-4d58-ab22-fd0f88cdd3bc"), "3" }
                });
        }
    }
}
