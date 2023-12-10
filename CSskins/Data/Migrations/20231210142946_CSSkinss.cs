using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSskins.Data.Migrations
{
    /// <inheritdoc />
    public partial class CSSkinss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categortyes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categortyes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CSCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CSCases_Categortyes_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categortyes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CSCases_CategoryId",
                table: "CSCases",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CSCases");

            migrationBuilder.DropTable(
                name: "Categortyes");
        }
    }
}
