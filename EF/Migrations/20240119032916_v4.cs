using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF1.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagIdNew",
                table: "Tags",
                newName: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Tags",
                newName: "TagIdNew");
        }
    }
}
