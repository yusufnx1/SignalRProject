using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRProject.Data.Migrations
{
    public partial class add_column_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterTitle",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterTitle",
                table: "ContactUs");
        }
    }
}
