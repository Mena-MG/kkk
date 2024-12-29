using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce_Application_1.Migrations
{
    /// <inheritdoc />
    public partial class modaddasdasadadadafsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classes");
        }
    }
}
