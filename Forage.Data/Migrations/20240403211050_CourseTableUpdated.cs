using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class CourseTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(5920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(2882));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(7840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(8235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(9291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 295, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 0, 56, 56, 296, DateTimeKind.Utc).AddTicks(2882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(4593));
        }
    }
}
