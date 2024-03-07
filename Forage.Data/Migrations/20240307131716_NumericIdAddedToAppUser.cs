using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forage.Data.Migrations
{
    public partial class NumericIdAddedToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(5306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.AddColumn<int>(
                name: "NumericId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumericId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrivacyNotices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HelpMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(5201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseLessonActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(6481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyIndustryFields",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(3257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 16, 14, 12, 939, DateTimeKind.Utc).AddTicks(2929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 7, 17, 17, 15, 953, DateTimeKind.Utc).AddTicks(2619));
        }
    }
}
