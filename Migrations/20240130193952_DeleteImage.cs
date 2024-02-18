using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portifolio.Migrations
{
    /// <inheritdoc />
    public partial class DeleteImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_General_Images_ImgUrlid",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ImgUrlid",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ImgUrlid",
                table: "Projects");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImgUrlid",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ImgUrlid",
                table: "Projects",
                column: "ImgUrlid");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_General_Images_ImgUrlid",
                table: "Projects",
                column: "ImgUrlid",
                principalTable: "General_Images",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
