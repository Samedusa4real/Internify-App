using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class CourseInternTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(4026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(2190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(4146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(1118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(3525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.CreateTable(
                name: "CourseInterns",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InternId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInterns", x => new { x.CourseId, x.InternId });
                    table.ForeignKey(
                        name: "FK_CourseInterns_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Specify ON DELETE NO ACTION

                    table.ForeignKey(
                        name: "FK_CourseInterns_Interns_InternId",
                        column: x => x.InternId,
                        principalTable: "Interns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Specify ON DELETE NO ACTION
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInterns_InternId",
                table: "CourseInterns",
                column: "InternId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInterns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(4692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(5982));

            
        }
    }
}
