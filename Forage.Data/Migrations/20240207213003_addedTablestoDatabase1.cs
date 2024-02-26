using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class addedTablestoDatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(8355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(9339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(5504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 536, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 117, DateTimeKind.Utc).AddTicks(34),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(7207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(2320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(4156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(4804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(7800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(7783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(9730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 536, DateTimeKind.Utc).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 117, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(7042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(4320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(1402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(8228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 116, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 3, 16, 1, 13, 537, DateTimeKind.Utc).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 8, 1, 30, 3, 115, DateTimeKind.Utc).AddTicks(9730));
        }
    }
}
