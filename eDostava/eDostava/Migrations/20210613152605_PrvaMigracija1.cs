using Microsoft.EntityFrameworkCore.Migrations;

namespace eDostava.Migrations
{
    public partial class PrvaMigracija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ECTS",
                table: "Proizvod");

            migrationBuilder.AddColumn<double>(
                name: "Kolicina",
                table: "Proizvod",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Proizvod");

            migrationBuilder.AddColumn<double>(
                name: "ECTS",
                table: "Proizvod",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
