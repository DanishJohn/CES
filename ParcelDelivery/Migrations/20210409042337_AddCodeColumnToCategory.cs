using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcelDelivery.Migrations
{
    public partial class AddCodeColumnToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ParcelCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ef415d7e-96ad-4cb8-90e8-c6a5415e3d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d8d5247f-700e-42b1-8fc1-a5bd9e275285");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08796e96-2dd2-4a1f-aaae-e660c3a24b3d", "AQAAAAEAACcQAAAAEL6YVabR8/jmLtFB9m2VP68thuAHe6oSQ6EIrguNq+ZV3cIFyBaWRVUJlB4ycwVSzQ==", "7dcf5bb0-79ef-459d-971c-61e272ca2224" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "ParcelCategory");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1e1cd1bb-25ad-4c61-a73c-e9a3a6bcd62a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0be54d07-c42b-475d-b696-a14bbdf46148");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c38ea073-cb43-4980-8bec-edbae1771b63", "AQAAAAEAACcQAAAAEMeTMP7A3yIf7qx34wmpqAQ8U2IeUXEZRxSbBMIAawpancvm/10PSr8b+OJ6/DwhBA==", "10b7491c-046d-4e66-8b7d-0610db0a043e" });
        }
    }
}
