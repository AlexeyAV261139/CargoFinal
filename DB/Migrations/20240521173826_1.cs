using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoEntity_CargoType_CargoTypeId",
                table: "CargoEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoType",
                table: "CargoType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoEntity",
                table: "CargoEntity");

            migrationBuilder.RenameTable(
                name: "CargoType",
                newName: "CargoTypes");

            migrationBuilder.RenameTable(
                name: "CargoEntity",
                newName: "Cargos");

            migrationBuilder.RenameIndex(
                name: "IX_CargoEntity_CargoTypeId",
                table: "Cargos",
                newName: "IX_Cargos_CargoTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoTypes",
                table: "CargoTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_CargoTypes_CargoTypeId",
                table: "Cargos",
                column: "CargoTypeId",
                principalTable: "CargoTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_CargoTypes_CargoTypeId",
                table: "Cargos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoTypes",
                table: "CargoTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos");

            migrationBuilder.RenameTable(
                name: "CargoTypes",
                newName: "CargoType");

            migrationBuilder.RenameTable(
                name: "Cargos",
                newName: "CargoEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Cargos_CargoTypeId",
                table: "CargoEntity",
                newName: "IX_CargoEntity_CargoTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoType",
                table: "CargoType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoEntity",
                table: "CargoEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoEntity_CargoType_CargoTypeId",
                table: "CargoEntity",
                column: "CargoTypeId",
                principalTable: "CargoType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
