using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class updatedInterns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(3029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(3619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FinNumber",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(4636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(1545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(6436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(5537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(8370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "FinNumber",
                table: "Interns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(3461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(4242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(9655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 230, DateTimeKind.Utc).AddTicks(1336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(5125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 12, 26, 4, 229, DateTimeKind.Utc).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(7419));
        }
    }
}
