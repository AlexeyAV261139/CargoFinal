using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
