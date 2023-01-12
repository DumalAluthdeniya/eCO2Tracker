using Microsoft.EntityFrameworkCore.Migrations;

namespace eCO2Tracker.Migrations
{
    public partial class AddIsPerformedColunmActivityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPerformed",
                table: "Activities",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPerformed",
                table: "Activities");
        }
    }
}
