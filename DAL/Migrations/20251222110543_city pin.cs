using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class citypin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_Language_LanguageId",
                table: "book");

            migrationBuilder.DropIndex(
                name: "IX_book_LanguageId",
                table: "book");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "book");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pincode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PinNo = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pincode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pincode_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pincode_CityId",
                table: "Pincode",
                column: "CityId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pincode");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_book_LanguageId",
                table: "book",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_book_Language_LanguageId",
                table: "book",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }
    }
}
