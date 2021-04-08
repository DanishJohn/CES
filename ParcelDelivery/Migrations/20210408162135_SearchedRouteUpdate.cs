using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcelDelivery.Migrations
{
    public partial class SearchedRouteUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchRouteHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureId = table.Column<int>(type: "int", nullable: true),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchRouteHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchRouteHistory_City_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SearchRouteHistory_City_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SearchRouteHistory_DepartureId",
                table: "SearchRouteHistory",
                column: "DepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchRouteHistory_DestinationId",
                table: "SearchRouteHistory",
                column: "DestinationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchRouteHistory");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8dfc8646-0077-48a6-8ce3-50387939f190");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c5194a63-c497-40dd-98e2-d2c6e3c5f5dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c58e0ed0-8b4b-430a-976b-ace43ce5949c", "AQAAAAEAACcQAAAAEA+ujNcnn4kA7eZ/1Z95N8m7ouYUdyiUJGPKo6zEhv34KZg3x6KdIOJHh9+qT5YvBg==", "db00eec1-93b5-4e7a-a412-bd99b16eaefc" });
        }
    }
}
