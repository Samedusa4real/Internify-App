using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class AboutLanguageTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstStratHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FirstStratText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FourthStratHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FourthStratText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MainHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MainText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SecondHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SecondStratHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SecondStratText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SmallHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ThirdStratHeader",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ThirdStratText",
                table: "Abouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(3199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(8212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(5794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.CreateTable(
                name: "AboutLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmallHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstStratHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstStratText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondStratHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondStratText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdStratHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdStratText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthStratHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthStratText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(6873)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutLanguages_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AboutLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_AboutId",
                table: "AboutLanguages",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_LanguageId",
                table: "AboutLanguages",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutLanguages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(8424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(7943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(9148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 338, DateTimeKind.Utc).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 654, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 39, 33, 339, DateTimeKind.Utc).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 5, 14, 35, 42, 655, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.AddColumn<string>(
                name: "FirstStratHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstStratText",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FourthStratHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FourthStratText",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainText",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondStratHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondStratText",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SmallHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdStratHeader",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdStratText",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
