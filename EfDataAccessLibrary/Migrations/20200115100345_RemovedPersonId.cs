using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDataAccessLibrary.Migrations
{
    public partial class RemovedPersonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresse",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse",
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

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresse",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
