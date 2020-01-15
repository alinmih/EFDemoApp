using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDataAccessLibrary.Migrations
{
    public partial class RemovedPersonIdInAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
