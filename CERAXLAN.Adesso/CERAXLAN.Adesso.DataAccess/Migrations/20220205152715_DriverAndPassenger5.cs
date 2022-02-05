using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    public partial class DriverAndPassenger5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatingCapacity",
                table: "Travels",
                newName: "MaxSeatingCapacity");

            migrationBuilder.AddColumn<int>(
                name: "CurrentSeatingCapacity",
                table: "Travels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentSeatingCapacity",
                table: "Travels");

            migrationBuilder.RenameColumn(
                name: "MaxSeatingCapacity",
                table: "Travels",
                newName: "SeatingCapacity");
        }
    }
}
