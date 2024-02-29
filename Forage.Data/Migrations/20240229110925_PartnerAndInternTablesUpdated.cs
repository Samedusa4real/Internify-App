using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class PartnerAndInternTablesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(5759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(8455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(9042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(8809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.AddColumn<string>(
                name: "ActualAddress",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyIndustryFieldId",
                table: "Partners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LegalAddress",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(5465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(6255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(4338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9857));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualAddress",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "CompanyIndustryFieldId",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "LegalAddress",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Partners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 15, 9, 25, 106, DateTimeKind.Utc).AddTicks(4338));
        }
    }
}
