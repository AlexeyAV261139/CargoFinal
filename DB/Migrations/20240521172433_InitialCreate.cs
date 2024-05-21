using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargoEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Requirements = table.Column<string>(type: "TEXT", nullable: true),
                    CargoTypeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoEntity_CargoType_CargoTypeId",
                        column: x => x.CargoTypeId,
                        principalTable: "CargoType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoEntity_CargoTypeId",
                table: "CargoEntity",
                column: "CargoTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoEntity");

            migrationBuilder.DropTable(
                name: "CargoType");
        }
    }
}
