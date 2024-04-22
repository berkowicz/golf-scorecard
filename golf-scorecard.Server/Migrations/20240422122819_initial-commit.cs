using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_scorecard.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseRefId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    HoleIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hole_Course_CourseRefId",
                        column: x => x.CourseRefId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SlopeRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CR = table.Column<float>(type: "real", nullable: false),
                    Slope = table.Column<float>(type: "real", nullable: false),
                    SchratchValue = table.Column<float>(type: "real", nullable: false),
                    CourseRefId = table.Column<int>(type: "int", nullable: false),
                    GenderRefId = table.Column<int>(type: "int", nullable: false),
                    TeeRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlopeRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlopeRating_Course_CourseRefId",
                        column: x => x.CourseRefId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlopeRating_Gender_GenderRefId",
                        column: x => x.GenderRefId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlopeRating_Tee_TeeRefId",
                        column: x => x.TeeRefId,
                        principalTable: "Tee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hole_CourseRefId",
                table: "Hole",
                column: "CourseRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SlopeRating_CourseRefId",
                table: "SlopeRating",
                column: "CourseRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SlopeRating_GenderRefId",
                table: "SlopeRating",
                column: "GenderRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SlopeRating_TeeRefId",
                table: "SlopeRating",
                column: "TeeRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hole");

            migrationBuilder.DropTable(
                name: "SlopeRating");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Tee");
        }
    }
}
