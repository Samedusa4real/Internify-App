using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class InternCoursesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(1579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(6335));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(3362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(9079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(4533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(5637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(5136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(1369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(3992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(3357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(8589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(5008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(9921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 386, DateTimeKind.Utc).AddTicks(2929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(4549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(6934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 22, 24, 53, 385, DateTimeKind.Utc).AddTicks(6335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(1579));
        }
    }
}
