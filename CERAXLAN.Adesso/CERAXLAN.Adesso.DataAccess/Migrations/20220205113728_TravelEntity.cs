using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CERAXLAN.Adesso.DataAccess.Migrations
{
    public partial class TravelEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Travels",
                columns: table => new
                {
                    TravelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhereFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    TravelStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travels", x => x.TravelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Travels");
        }
    }
}
