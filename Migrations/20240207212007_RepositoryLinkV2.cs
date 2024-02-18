using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portifolio.Migrations
{
    /// <inheritdoc />
    public partial class RepositoryLinkV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link_Repository",
                table: "Projects",
                newName: "LinkRepository");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkRepository",
                table: "Projects",
                newName: "Link_Repository");
        }
    }
}
