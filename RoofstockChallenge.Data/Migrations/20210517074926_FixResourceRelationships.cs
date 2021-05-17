using Microsoft.EntityFrameworkCore.Migrations;

namespace RoofstockChallenge.Data.Migrations
{
    public partial class FixResourceRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyResources_ResourcesIdPropertyResource",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource1",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource2",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource3",
                table: "Resource");

            migrationBuilder.DropTable(
                name: "PropertyResources");

            migrationBuilder.DropIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource1",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource2",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Property_ResourcesIdPropertyResource",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "PropertyResourcesIdPropertyResource",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "PropertyResourcesIdPropertyResource1",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "PropertyResourcesIdPropertyResource2",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "ResourcesIdPropertyResource",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "PropertyResourcesIdPropertyResource3",
                table: "Resource",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource3",
                table: "Resource",
                newName: "IX_Resource_PropertyId");

            migrationBuilder.AlterColumn<string>(
                name: "ResourceType",
                table: "Resource",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Property_PropertyId",
                table: "Resource",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Property_PropertyId",
                table: "Resource");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "Resource",
                newName: "PropertyResourcesIdPropertyResource3");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_PropertyId",
                table: "Resource",
                newName: "IX_Resource_PropertyResourcesIdPropertyResource3");

            migrationBuilder.AlterColumn<string>(
                name: "ResourceType",
                table: "Resource",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PropertyResourcesIdPropertyResource",
                table: "Resource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyResourcesIdPropertyResource1",
                table: "Resource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyResourcesIdPropertyResource2",
                table: "Resource",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResourcesIdPropertyResource",
                table: "Property",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyResources",
                columns: table => new
                {
                    IdPropertyResource = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyResources", x => x.IdPropertyResource);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource1",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource1");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource2",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource2");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ResourcesIdPropertyResource",
                table: "Property",
                column: "ResourcesIdPropertyResource");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyResources_ResourcesIdPropertyResource",
                table: "Property",
                column: "ResourcesIdPropertyResource",
                principalTable: "PropertyResources",
                principalColumn: "IdPropertyResource",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource",
                principalTable: "PropertyResources",
                principalColumn: "IdPropertyResource",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource1",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource1",
                principalTable: "PropertyResources",
                principalColumn: "IdPropertyResource",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource2",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource2",
                principalTable: "PropertyResources",
                principalColumn: "IdPropertyResource",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource3",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource3",
                principalTable: "PropertyResources",
                principalColumn: "IdPropertyResource",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
