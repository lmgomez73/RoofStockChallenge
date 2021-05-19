using Microsoft.EntityFrameworkCore.Migrations;

namespace RoofstockChallenge.Data.Migrations
{
    public partial class FixAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Address_AddressIdAddress",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_AddressIdAddress",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "AddressIdAddress",
                table: "Property");

            migrationBuilder.AddColumn<int>(
                name: "IdProperty",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 1,
                column: "IdProperty",
                value: 1625006);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 2,
                column: "IdProperty",
                value: 1625007);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 3,
                column: "IdProperty",
                value: 1625008);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 4,
                column: "IdProperty",
                value: 1625009);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 5,
                column: "IdProperty",
                value: 1625010);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 6,
                column: "IdProperty",
                value: 1625011);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 7,
                column: "IdProperty",
                value: 1625012);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 8,
                column: "IdProperty",
                value: 1625013);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 9,
                column: "IdProperty",
                value: 1625014);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: 10,
                column: "IdProperty",
                value: 1625015);

            migrationBuilder.CreateIndex(
                name: "IX_Address_IdProperty",
                table: "Address",
                column: "IdProperty",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Property_IdProperty",
                table: "Address",
                column: "IdProperty",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Property_IdProperty",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_IdProperty",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "IdProperty",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressIdAddress",
                table: "Property",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_AddressIdAddress",
                table: "Property",
                column: "AddressIdAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Address_AddressIdAddress",
                table: "Property",
                column: "AddressIdAddress",
                principalTable: "Address",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
