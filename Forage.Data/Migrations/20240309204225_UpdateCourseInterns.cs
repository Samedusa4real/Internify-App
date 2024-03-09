using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class UpdateCourseInterns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(1505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(4868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(5585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(5272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(7639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(1193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(3813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseInterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CourseInterns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseInterns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CourseInterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(9719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(5982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CourseInterns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseInterns");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseInterns");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CourseInterns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(4026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(2190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(9026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(4146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(1118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 136, DateTimeKind.Utc).AddTicks(3525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 232, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 10, 0, 2, 33, 135, DateTimeKind.Utc).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 10, 0, 42, 25, 231, DateTimeKind.Utc).AddTicks(9719));
        }
    }
}
