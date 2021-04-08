using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcelDelivery.Migrations
{
    public partial class SeedUserAndRenameParcelCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parcelcategory",
                table: "Parcelcategory");

            migrationBuilder.RenameTable(
                name: "Parcelcategory",
                newName: "ParcelCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParcelCategory",
                table: "ParcelCategory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "8dfc8646-0077-48a6-8ce3-50387939f190", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "c5194a63-c497-40dd-98e2-d2c6e3c5f5dd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "c58e0ed0-8b4b-430a-976b-ace43ce5949c", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEA+ujNcnn4kA7eZ/1Z95N8m7ouYUdyiUJGPKo6zEhv34KZg3x6KdIOJHh9+qT5YvBg==", null, false, "db00eec1-93b5-4e7a-a412-bd99b16eaefc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParcelCategory",
                table: "ParcelCategory");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.RenameTable(
                name: "ParcelCategory",
                newName: "Parcelcategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parcelcategory",
                table: "Parcelcategory",
                column: "Id");
        }
    }
}
