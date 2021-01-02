using Microsoft.EntityFrameworkCore.Migrations;

namespace Check_Roles.Data.Migrations
{
    public partial class all_tables_completed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fachbereich",
                columns: table => new
                {
                    FachbereichId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AdminId = table.Column<int>(nullable: true),
                    Studiengänge = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fachbereich", x => x.FachbereichId);
                });

            migrationBuilder.CreateTable(
                name: "Modulhandbuch",
                columns: table => new
                {
                    ModulhandbuchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FachbereichId = table.Column<int>(nullable: true),
                    StudiengangId = table.Column<int>(nullable: true),
                    Prüfungsordnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulhandbuch", x => x.ModulhandbuchId);
                });

            migrationBuilder.CreateTable(
                name: "Studiengang",
                columns: table => new
                {
                    StudiengangId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FachbereichId = table.Column<int>(nullable: true),
                    Modulhandbücher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studiengang", x => x.StudiengangId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fachbereich");

            migrationBuilder.DropTable(
                name: "Modulhandbuch");

            migrationBuilder.DropTable(
                name: "Studiengang");
        }
    }
}
