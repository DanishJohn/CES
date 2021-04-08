using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcelDelivery.Migrations
{
    public partial class ChangeWeightToEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "ParcelWeight",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<bool>(
                name: "IsSupported",
                table: "ParcelWeight",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSupported",
                table: "ParcelWeight");

            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "ParcelWeight",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
