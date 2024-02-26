using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class addPartners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(6494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(3556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(5918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(8131)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(9409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(8978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(54),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(1839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 207, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 18, 2, 56, 31, 206, DateTimeKind.Utc).AddTicks(8977));
        }
    }
}
