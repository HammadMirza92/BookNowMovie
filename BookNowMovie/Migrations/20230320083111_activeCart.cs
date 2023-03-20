using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookNowMovie.Migrations
{
    public partial class activeCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CartItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2155), new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 23, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 3, 20, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 27, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 3, 20, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 18, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 3, 10, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 9, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 3, 23, 13, 31, 11, 478, DateTimeKind.Local).AddTicks(2248) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 27, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 3, 7, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 20, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 3, 17, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 24, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 3, 17, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 12, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 3, 7, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 3, 15, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 3, 7, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 4, 6, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 3, 20, 21, 13, 21, 675, DateTimeKind.Local).AddTicks(3744) });
        }
    }
}
