using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class CompIndustryFieldCanNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(3257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1986));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(6033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(3735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(4014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(5144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 14, 20, 15, 512, DateTimeKind.Utc).AddTicks(1986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2929));
        }
    }
}
