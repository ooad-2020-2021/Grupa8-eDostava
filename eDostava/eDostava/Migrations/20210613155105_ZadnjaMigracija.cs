using Microsoft.EntityFrameworkCore.Migrations;

namespace eDostava.Migrations
{
    public partial class ZadnjaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Proizvod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Proizvod",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
