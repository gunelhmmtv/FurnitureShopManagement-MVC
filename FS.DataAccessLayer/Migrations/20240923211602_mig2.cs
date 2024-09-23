using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FS.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProductOrders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 9, 21, 19, 45, 44, 504, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 45, 44, 503, DateTimeKind.Utc).AddTicks(1443), new DateTime(2024, 9, 21, 19, 45, 44, 503, DateTimeKind.Utc).AddTicks(1446) });
        }
    }
}
