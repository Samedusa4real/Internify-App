using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class CoursesAddedToIntern : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.AddColumn<int>(
                name: "InternId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InternId",
                table: "Courses",
                column: "InternId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Interns_InternId",
                table: "Courses",
                column: "InternId",
                principalTable: "Interns",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Interns_InternId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_InternId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "InternId",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(1314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(8010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Interns",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interns",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(6108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(5229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(6800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(2323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 14, 14, 58, 157, DateTimeKind.Utc).AddTicks(3208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1986));
        }
    }
}
