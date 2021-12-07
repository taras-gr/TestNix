using Microsoft.EntityFrameworkCore.Migrations;

namespace UrlShort.Repositories.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrlEntities",
                columns: table => new
                {
                    ShortedUrl = table.Column<string>(nullable: false),
                    FullUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlEntities", x => x.ShortedUrl);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlEntities");
        }
    }
}
