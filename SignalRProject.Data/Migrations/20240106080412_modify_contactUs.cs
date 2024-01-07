using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRProject.Data.Migrations
{
    public partial class modify_contactUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpenDays",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenDaysDescription",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenHours",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenDays",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "OpenDaysDescription",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "OpenHours",
                table: "ContactUs");
        }
    }
}
