using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComApp.Migrations
{
    public partial class add_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "ServiceItems",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb604fa9-8ca3-44d4-a2a7-08bd007264bc",
                column: "ConcurrencyStamp",
                value: "5efe50f5-0e6b-481f-b4c8-7842e5fe5392");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28f5c4c9-9dab-4a6e-bbed-c2154ab68d7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f109df4-539b-49af-9a17-1537167e9738", "AQAAAAEAACcQAAAAEF7BvKAG5kr89qoO5m6eLetd+o1Ze/J6DfP/WLA538KqyL7lGhkZp0OIa7cAh8OLpg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("42220e70-d68c-49eb-833c-c5e7634deb31"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 28, 15, 1, 34, 287, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80dd1009-80b2-4f68-b5a1-cd6d446ad179"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 28, 15, 1, 34, 287, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c382b28b-4349-4555-8cbd-4184dc7f4470"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 28, 15, 1, 34, 287, DateTimeKind.Utc).AddTicks(8597));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb604fa9-8ca3-44d4-a2a7-08bd007264bc",
                column: "ConcurrencyStamp",
                value: "23b8d34e-88dc-443b-b1cd-afe25b006172");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28f5c4c9-9dab-4a6e-bbed-c2154ab68d7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b901421-b7bd-4dd9-bcdd-eb8b721aea10", "AQAAAAEAACcQAAAAEOqeO/LIOpYjP1WCDqqD9QTXMrYRrpYp/38XRvOkOgrbzJPEdmp3ry/QslBkGOtSSw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("42220e70-d68c-49eb-833c-c5e7634deb31"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 26, 14, 30, 22, 22, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80dd1009-80b2-4f68-b5a1-cd6d446ad179"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 26, 14, 30, 22, 21, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c382b28b-4349-4555-8cbd-4184dc7f4470"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 26, 14, 30, 22, 22, DateTimeKind.Utc).AddTicks(2033));
        }
    }
}
