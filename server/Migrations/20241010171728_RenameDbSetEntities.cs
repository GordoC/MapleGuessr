using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class RenameDbSetEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Map_Region_RegionId",
                table: "Map");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_World_WorldId",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_World",
                table: "World");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Map",
                table: "Map");

            migrationBuilder.RenameTable(
                name: "World",
                newName: "Worlds");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regions");

            migrationBuilder.RenameTable(
                name: "Map",
                newName: "Maps");

            migrationBuilder.RenameIndex(
                name: "IX_Region_WorldId",
                table: "Regions",
                newName: "IX_Regions_WorldId");

            migrationBuilder.RenameIndex(
                name: "IX_Map_RegionId",
                table: "Maps",
                newName: "IX_Maps_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worlds",
                table: "Worlds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maps",
                table: "Maps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Regions_RegionId",
                table: "Maps",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Worlds_WorldId",
                table: "Regions",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Regions_RegionId",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Worlds_WorldId",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Worlds",
                table: "Worlds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maps",
                table: "Maps");

            migrationBuilder.RenameTable(
                name: "Worlds",
                newName: "World");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "Maps",
                newName: "Map");

            migrationBuilder.RenameIndex(
                name: "IX_Regions_WorldId",
                table: "Region",
                newName: "IX_Region_WorldId");

            migrationBuilder.RenameIndex(
                name: "IX_Maps_RegionId",
                table: "Map",
                newName: "IX_Map_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_World",
                table: "World",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Map",
                table: "Map",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Map_Region_RegionId",
                table: "Map",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Region_World_WorldId",
                table: "Region",
                column: "WorldId",
                principalTable: "World",
                principalColumn: "Id");
        }
    }
}
