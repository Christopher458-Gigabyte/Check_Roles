using Microsoft.EntityFrameworkCore.Migrations;

namespace Check_Roles.Data.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dozent",
                table: "Module",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dozent",
                table: "Module");
        }
    }
}
