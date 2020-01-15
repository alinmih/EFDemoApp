using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDataAccessLibrary.Migrations
{
    public partial class RenamedStreetAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreeetAddress",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Addresses",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "StreeetAddress",
                table: "Addresses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
