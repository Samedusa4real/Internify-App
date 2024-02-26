using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class addSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(9409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(8978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(54),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(1839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2975)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(7370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 328, DateTimeKind.Utc).AddTicks(2085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 472, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(8234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 15, 29, 8, 327, DateTimeKind.Utc).AddTicks(7911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 13, 19, 32, 56, 471, DateTimeKind.Utc).AddTicks(7458));
        }
    }
}
