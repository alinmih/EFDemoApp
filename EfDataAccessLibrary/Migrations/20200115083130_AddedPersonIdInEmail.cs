using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDataAccessLibrary.Migrations
{
    public partial class AddedPersonIdInEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresse",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresse_People_PersonId",
                table: "EmailAddresse",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
