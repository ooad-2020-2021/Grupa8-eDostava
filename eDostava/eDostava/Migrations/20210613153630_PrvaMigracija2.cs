using Microsoft.EntityFrameworkCore.Migrations;

namespace eDostava.Migrations
{
    public partial class PrvaMigracija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Proizvod",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Proizvod");
        }
    }
}
