using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class InternTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(7266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(1223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(5481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(9645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(9220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniGraduationYear",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniStartYear",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniversityName",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(6655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(8051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(2569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(6598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(9318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2619));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "UniGraduationYear",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "UniStartYear",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "UniversityName",
                table: "Interns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(5306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 524, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 18, 38, 1, 523, DateTimeKind.Utc).AddTicks(9318));
        }
    }
}
