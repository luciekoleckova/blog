using Microsoft.EntityFrameworkCore.Migrations;

namespace AspBlog.Data.Migrations
{
    public partial class Vytvoreni_Clanku : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Obsah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Popis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
