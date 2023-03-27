using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookNowMovie.Migrations
{
    public partial class updateActorMovies2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 3, 17, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 30, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 3, 27, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 3, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 3, 27, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 22, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 3, 17, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 25, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6375), new DateTime(2023, 3, 17, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6394), new DateTime(2023, 3, 30, 15, 26, 39, 347, DateTimeKind.Local).AddTicks(6393) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
