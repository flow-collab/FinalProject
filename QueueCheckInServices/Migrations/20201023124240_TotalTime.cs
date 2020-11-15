using Microsoft.EntityFrameworkCore.Migrations;

namespace QueueCheckIn.Services.Migrations
{
    public partial class TotalTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalTime",
                table: "CheckIns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "CheckIns");
        }
    }
}
