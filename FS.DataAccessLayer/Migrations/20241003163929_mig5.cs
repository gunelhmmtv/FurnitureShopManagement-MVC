using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FS.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9158), new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9161), new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9164), new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9165), new DateTime(2024, 10, 3, 16, 39, 29, 201, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 39, 29, 200, DateTimeKind.Utc).AddTicks(9258), new DateTime(2024, 10, 3, 16, 39, 29, 200, DateTimeKind.Utc).AddTicks(9260) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7692), new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7698), new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7700), new DateTime(2024, 9, 23, 21, 16, 2, 196, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 21, 16, 2, 195, DateTimeKind.Utc).AddTicks(5170), new DateTime(2024, 9, 23, 21, 16, 2, 195, DateTimeKind.Utc).AddTicks(5173) });
        }
    }
}
