using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class alterOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PickupTime",
                table: "OrderHeader",
                newName: "PickUpTime");

            migrationBuilder.AlterColumn<double>(
                name: "CouponCodeDiscount",
                table: "OrderHeader",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PickUpTime",
                table: "OrderHeader",
                newName: "PickupTime");

            migrationBuilder.AlterColumn<string>(
                name: "CouponCodeDiscount",
                table: "OrderHeader",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
