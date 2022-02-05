using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    public partial class DriverAndPassenger6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Travels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Travels_PassengerId",
                table: "Travels",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travels_Passengers_PassengerId",
                table: "Travels",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travels_Passengers_PassengerId",
                table: "Travels");

            migrationBuilder.DropIndex(
                name: "IX_Travels_PassengerId",
                table: "Travels");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Travels");
        }
    }
}
