using Microsoft.EntityFrameworkCore.Migrations;

namespace QueueCheckIn.Services.Migrations
{
    public partial class CategoryTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WaitTime",
                table: "CheckIns");

            migrationBuilder.AddColumn<int>(
                name: "CategoryTime",
                table: "CheckIns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryTime",
                table: "CheckIns");

            migrationBuilder.AddColumn<int>(
                name: "WaitTime",
                table: "CheckIns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
