using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RouteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DriverId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CarId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CargoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DifficultyClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8f600658-7826-4ea3-a0b0-42a5e3d0218f"), "1" },
                    { new Guid("dd1fc763-9043-4fe6-93be-dbe1d891d6f9"), "2" },
                    { new Guid("f6c1fc7b-47c4-4614-97c3-a0b169720032"), "3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CargoId",
                table: "Trips",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CarId",
                table: "Trips",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverId",
                table: "Trips",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_RouteId",
                table: "Trips",
                column: "RouteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("8f600658-7826-4ea3-a0b0-42a5e3d0218f"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("dd1fc763-9043-4fe6-93be-dbe1d891d6f9"));

            migrationBuilder.DeleteData(
                table: "DifficultyClasses",
                keyColumn: "Id",
                keyValue: new Guid("f6c1fc7b-47c4-4614-97c3-a0b169720032"));

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
    }
}
