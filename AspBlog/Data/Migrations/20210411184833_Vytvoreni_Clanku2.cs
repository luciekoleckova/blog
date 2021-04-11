using Microsoft.EntityFrameworkCore.Migrations;

namespace AspBlog.Data.Migrations
{
    public partial class Vytvoreni_Clanku2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Article",
                newName: "Titul");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Article",
                newName: "Popis");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Article",
                newName: "Obsah");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titul",
                table: "Article",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Popis",
                table: "Article",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Obsah",
                table: "Article",
                newName: "Content");
        }
    }
}
