using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    public partial class DriverAndPassenger7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Travels_Passengers_PassengerId",
                table: "Travels");

            migrationBuilder.DropIndex(
                name: "IX_Travels_PassengerId",
                table: "Travels");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Travels");

            migrationBuilder.AlterColumn<int>(
                name: "TravelId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers",
                column: "TravelId",
                principalTable: "Travels",
                principalColumn: "TravelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Travels",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TravelId",
                table: "Passengers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_PassengerId",
                table: "Travels",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers",
                column: "TravelId",
                principalTable: "Travels",
                principalColumn: "TravelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Travels_Passengers_PassengerId",
                table: "Travels",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
