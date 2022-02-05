using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    public partial class DriverAndPassenger10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers");

            migrationBuilder.AlterColumn<int>(
                name: "TravelId",
                table: "Passengers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers",
                column: "TravelId",
                principalTable: "Travels",
                principalColumn: "TravelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Travels_TravelId",
                table: "Passengers");

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
    }
}
