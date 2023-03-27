using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookNowMovie.Migrations
{
    public partial class updateActorMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 3, 17, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 30, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 3, 27, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 3, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 3, 27, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 3, 17, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 25, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 3, 17, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 16, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 3, 30, 14, 56, 22, 566, DateTimeKind.Local).AddTicks(1180) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 1, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 3, 12, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 25, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 3, 22, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 29, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 3, 22, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 3, 12, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 20, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 3, 12, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 11, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 3, 25, 15, 45, 31, 768, DateTimeKind.Local).AddTicks(7397) });
        }
    }
}
