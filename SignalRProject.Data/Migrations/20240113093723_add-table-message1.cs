using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRProject.Data.Migrations
{
    public partial class addtablemessage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Messages");
        }
    }
}
