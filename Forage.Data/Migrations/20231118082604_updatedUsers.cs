using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class updatedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(3461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(8977));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(6494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(8131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(3556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(5918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6202));
        }
    }
}
