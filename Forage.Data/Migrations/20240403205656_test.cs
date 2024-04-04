using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutVideo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AboutVideoUrl",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ShortInfo",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(2882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(4543));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(2255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(6777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(6467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.AddColumn<string>(
                name: "AboutVideo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutVideoUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortInfo",
                table: "Courses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(7326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(9872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(1125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(8351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 33, DateTimeKind.Utc).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 53, 28, 34, DateTimeKind.Utc).AddTicks(4543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(2882));
        }
    }
}
