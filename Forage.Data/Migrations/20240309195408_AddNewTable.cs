using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class AddNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(4692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(1579));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(6704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(7064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(4350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 936, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 540, DateTimeKind.Utc).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 23, 50, 55, 541, DateTimeKind.Utc).AddTicks(1579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 23, 54, 7, 935, DateTimeKind.Utc).AddTicks(7159));
        }
    }
}
