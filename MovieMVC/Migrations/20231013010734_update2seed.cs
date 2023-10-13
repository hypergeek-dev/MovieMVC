using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMVC.Migrations
{
    public partial class update2seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ImagePost" },
                values: new object[] { new DateTime(2023, 10, 13, 3, 7, 34, 509, DateTimeKind.Local).AddTicks(1547), "https://adambergaoui.files.wordpress.com/2016/11/goodfellas.jpg?w=860" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ImagePost" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 59, 42, 383, DateTimeKind.Local).AddTicks(4341), "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V" });
        }
    }
}
