using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class LanguagesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(8424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(5920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(1209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 97, DateTimeKind.Utc).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 1, 10, 50, 98, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(3164));
        }
    }
}
