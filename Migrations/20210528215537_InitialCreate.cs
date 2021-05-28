using Microsoft.EntityFrameworkCore.Migrations;

namespace Survey.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RepeatPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => new { x.Name, x.Id });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
