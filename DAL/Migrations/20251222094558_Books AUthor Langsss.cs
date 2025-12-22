using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class BooksAUthorLangsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Language_LanguageID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Language",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LanguageID",
                table: "Book",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_LanguageID",
                table: "Book",
                newName: "IX_Book_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Language",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Book",
                newName: "LanguageID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_LanguageId",
                table: "Book",
                newName: "IX_Book_LanguageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Language_LanguageID",
                table: "Book",
                column: "LanguageID",
                principalTable: "Language",
                principalColumn: "ID");
        }
    }
}
