using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_scorecard.Migrations
{
    /// <inheritdoc />
    public partial class Updaded_SlopeRating_Index_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Index",
                table: "Hole",
                newName: "HoleIndex");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoleIndex",
                table: "Hole",
                newName: "Index");
        }
    }
}
