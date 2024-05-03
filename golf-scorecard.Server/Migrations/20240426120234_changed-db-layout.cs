using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_scorecard.Server.Migrations
{
    /// <inheritdoc />
    public partial class changeddblayout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Par",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Par",
                value: 72);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Par",
                table: "Courses");
        }
    }
}
