using Microsoft.EntityFrameworkCore.Migrations;

namespace Check_Roles.Data.Migrations
{
    public partial class Dozenten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dozenten",
                columns: table => new
                {
                    DozentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Module = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dozenten", x => x.DozentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dozenten");
        }
    }
}
