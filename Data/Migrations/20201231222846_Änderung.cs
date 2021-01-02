using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Check_Roles.Data.Migrations
{
    public partial class Änderung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Änderung",
                columns: table => new
                {
                    ÄnderungId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(nullable: true),
                    DozentId = table.Column<int>(nullable: true),
                    ModulId = table.Column<int>(nullable: true),
                    AlterEintrag = table.Column<string>(nullable: true),
                    NeuerEintrag = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: true),
                    ModulhandbuchId = table.Column<int>(nullable: true),
                    Fachbereich = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Änderung", x => x.ÄnderungId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Änderung");
        }
    }
}
