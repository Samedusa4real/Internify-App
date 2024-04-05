using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class CourseTableUpdatedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(32),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(5751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 461, DateTimeKind.Utc).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(2071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(8027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 461, DateTimeKind.Utc).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(5374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.AlterColumn<string>(
                name: "CourseDuration",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(1365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(6487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(7155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(9582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(3951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(6546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutLanguages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(6873));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 461, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(3199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 461, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.AlterColumn<string>(
                name: "CourseDuration",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(8212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 462, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(5794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutLanguages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(6873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 17, 5, 27, 463, DateTimeKind.Utc).AddTicks(7970));
        }
    }
}
