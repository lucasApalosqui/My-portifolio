using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portifolio.Migrations
{
    /// <inheritdoc />
    public partial class PageNameAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageName",
                table: "Projects",
                type: "VARCHAR(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageName",
                table: "Projects");
        }
    }
}
