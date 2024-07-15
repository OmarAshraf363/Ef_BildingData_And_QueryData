using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddToResourceAndHomeWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8949), new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "HomeworkId", "Content", "Contentype", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, "Math Homework Content", 1, 2, 1, new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(9090) },
                    { 2, "Physics Homework Content", 0, 3, 2, new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(9094) },
                    { 3, "Chemistry Homework Content", 2, 1, 3, new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(9096) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Math Book", 2, "http://mathbook.com" },
                    { 2, 2, "Physics Video", 0, "http://physicsvideo.com" },
                    { 3, 3, "Chemistry Presentation", 1, "http://chemistrypresentation.com" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 15, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 10, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 12, 13, 0, 53, 896, DateTimeKind.Local).AddTicks(8802));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7375), new DateTime(2024, 7, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 7, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 7, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 15, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 10, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "RegisteredOn",
                value: new DateTime(2024, 7, 12, 12, 55, 20, 926, DateTimeKind.Local).AddTicks(7280));
        }
    }
}
