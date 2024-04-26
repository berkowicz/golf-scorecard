using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_scorecard.Server.Migrations
{
    /// <inheritdoc />
    public partial class changednametoplural : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hole_Course_CourseRefId",
                table: "Hole");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRating_Course_CourseRefId",
                table: "SlopeRating");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRating_Gender_GenderRefId",
                table: "SlopeRating");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRating_Tee_TeeRefId",
                table: "SlopeRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tee",
                table: "Tee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlopeRating",
                table: "SlopeRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hole",
                table: "Hole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Tee",
                newName: "Tees");

            migrationBuilder.RenameTable(
                name: "SlopeRating",
                newName: "SlopeRatings");

            migrationBuilder.RenameTable(
                name: "Hole",
                newName: "Holes");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRating_TeeRefId",
                table: "SlopeRatings",
                newName: "IX_SlopeRatings_TeeRefId");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRating_GenderRefId",
                table: "SlopeRatings",
                newName: "IX_SlopeRatings_GenderRefId");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRating_CourseRefId",
                table: "SlopeRatings",
                newName: "IX_SlopeRatings_CourseRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Hole_CourseRefId",
                table: "Holes",
                newName: "IX_Holes_CourseRefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tees",
                table: "Tees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlopeRatings",
                table: "SlopeRatings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holes",
                table: "Holes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Holes_Courses_CourseRefId",
                table: "Holes",
                column: "CourseRefId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRatings_Courses_CourseRefId",
                table: "SlopeRatings",
                column: "CourseRefId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRatings_Genders_GenderRefId",
                table: "SlopeRatings",
                column: "GenderRefId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRatings_Tees_TeeRefId",
                table: "SlopeRatings",
                column: "TeeRefId",
                principalTable: "Tees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holes_Courses_CourseRefId",
                table: "Holes");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRatings_Courses_CourseRefId",
                table: "SlopeRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRatings_Genders_GenderRefId",
                table: "SlopeRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_SlopeRatings_Tees_TeeRefId",
                table: "SlopeRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tees",
                table: "Tees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlopeRatings",
                table: "SlopeRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holes",
                table: "Holes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Tees",
                newName: "Tee");

            migrationBuilder.RenameTable(
                name: "SlopeRatings",
                newName: "SlopeRating");

            migrationBuilder.RenameTable(
                name: "Holes",
                newName: "Hole");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRatings_TeeRefId",
                table: "SlopeRating",
                newName: "IX_SlopeRating_TeeRefId");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRatings_GenderRefId",
                table: "SlopeRating",
                newName: "IX_SlopeRating_GenderRefId");

            migrationBuilder.RenameIndex(
                name: "IX_SlopeRatings_CourseRefId",
                table: "SlopeRating",
                newName: "IX_SlopeRating_CourseRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Holes_CourseRefId",
                table: "Hole",
                newName: "IX_Hole_CourseRefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tee",
                table: "Tee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlopeRating",
                table: "SlopeRating",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hole",
                table: "Hole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hole_Course_CourseRefId",
                table: "Hole",
                column: "CourseRefId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRating_Course_CourseRefId",
                table: "SlopeRating",
                column: "CourseRefId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRating_Gender_GenderRefId",
                table: "SlopeRating",
                column: "GenderRefId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlopeRating_Tee_TeeRefId",
                table: "SlopeRating",
                column: "TeeRefId",
                principalTable: "Tee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
