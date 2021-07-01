using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApi_Project.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HeadLine",
                table: "Reviews",
                newName: "Headline");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Headline",
                table: "Reviews",
                newName: "HeadLine");
        }
    }
}
