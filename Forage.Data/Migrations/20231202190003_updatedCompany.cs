using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class updatedCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voen",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Companies",
                newName: "LegalAddress");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(7559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(9638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(9742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(4815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 572, DateTimeKind.Utc).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(8829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(7619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(2305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(2457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(6640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(5803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.AddColumn<string>(
                name: "ActualAddress",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualAddress",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "LegalAddress",
                table: "Companies",
                newName: "Address");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(3029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(3619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 572, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(4636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 569, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(1545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(6436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 834, DateTimeKind.Utc).AddTicks(5537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 835, DateTimeKind.Utc).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 571, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(5908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(8370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 1, 11, 37, 39, 833, DateTimeKind.Utc).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 2, 23, 0, 3, 570, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.AddColumn<string>(
                name: "Voen",
                table: "Companies",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
