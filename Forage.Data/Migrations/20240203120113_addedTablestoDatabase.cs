using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class addedTablestoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 536, DateTimeKind.Utc).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 572, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(7042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(1402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(4499));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(7559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(9638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(9742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(4815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 536, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 572, DateTimeKind.Utc).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(8829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(7619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(2305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(2457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(6640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(5803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2388));
        }
    }
}
