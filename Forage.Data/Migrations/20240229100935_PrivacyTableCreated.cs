using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class PrivacyTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.CreateTable(
                name: "PrivacyNotices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(4184)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyNotices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivacyNotices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(3237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(1644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 228, DateTimeKind.Utc).AddTicks(2303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(9470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 525, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 26, 14, 47, 45, 227, DateTimeKind.Utc).AddTicks(9202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 14, 9, 35, 524, DateTimeKind.Utc).AddTicks(9857));
        }
    }
}
