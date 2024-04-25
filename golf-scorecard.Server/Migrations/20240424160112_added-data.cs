using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace golf_scorecard.Server.Migrations
{
    /// <inheritdoc />
    public partial class addeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SchratchValue",
                table: "SlopeRating",
                newName: "ScratchValue");

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "SlopeRating",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Nacka GK" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Man" },
                    { 2, "Woman" }
                });

            migrationBuilder.InsertData(
                table: "Tee",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Yellow" },
                    { 2, "Red" }
                });

            migrationBuilder.InsertData(
                table: "Hole",
                columns: new[] { "Id", "CourseRefId", "HoleIndex", "Number", "Par" },
                values: new object[,]
                {
                    { 1, 1, 10, 1, 4 },
                    { 2, 1, 6, 2, 3 },
                    { 3, 1, 14, 3, 5 },
                    { 4, 1, 4, 4, 4 },
                    { 5, 1, 8, 5, 5 },
                    { 6, 1, 18, 6, 3 },
                    { 7, 1, 2, 7, 4 },
                    { 8, 1, 16, 8, 4 },
                    { 9, 1, 12, 9, 3 },
                    { 10, 1, 11, 10, 4 },
                    { 11, 1, 13, 11, 5 },
                    { 12, 1, 3, 12, 4 },
                    { 13, 1, 9, 13, 3 },
                    { 14, 1, 1, 14, 4 },
                    { 15, 1, 17, 15, 4 },
                    { 16, 1, 15, 16, 3 },
                    { 17, 1, 5, 17, 5 },
                    { 18, 1, 7, 18, 4 }
                });

            migrationBuilder.InsertData(
                table: "SlopeRating",
                columns: new[] { "Id", "CR", "CourseRefId", "GenderRefId", "Info", "ScratchValue", "Slope", "TeeRefId" },
                values: new object[,]
                {
                    { 1, 69f, 1, 1, "Nacka Yellow Man", -2f, 124f, 1 },
                    { 2, 65.3f, 1, 1, "Nacka Red Man", -5.7f, 117f, 2 },
                    { 3, 74.5f, 1, 2, "Nacka Yellow Woman", 3.5f, 131f, 1 },
                    { 4, 70f, 1, 2, "Nacka Red Woman", -1f, 122f, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hole",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SlopeRating",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SlopeRating",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SlopeRating",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SlopeRating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Info",
                table: "SlopeRating");

            migrationBuilder.RenameColumn(
                name: "ScratchValue",
                table: "SlopeRating",
                newName: "SchratchValue");
        }
    }
}
