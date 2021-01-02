using Microsoft.EntityFrameworkCore.Migrations;

namespace Check_Roles.Data.Migrations
{
    public partial class etwas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Module",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Module",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Module");
        }
    }
}
