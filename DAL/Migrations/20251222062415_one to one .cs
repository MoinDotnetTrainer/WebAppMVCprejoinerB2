using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class onetoone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AadharTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AadharTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValidateModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidateModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pantbl",
                columns: table => new
                {
                    PanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefId = table.Column<int>(type: "int", nullable: false),
                    AadharDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantbl", x => x.PanID);
                    table.ForeignKey(
                        name: "FK_Pantbl_AadharTbl_AadharDataId",
                        column: x => x.AadharDataId,
                        principalTable: "AadharTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pantbl_AadharDataId",
                table: "Pantbl",
                column: "AadharDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pantbl");

            migrationBuilder.DropTable(
                name: "ValidateModel");

            migrationBuilder.DropTable(
                name: "AadharTbl");
        }
    }
}
