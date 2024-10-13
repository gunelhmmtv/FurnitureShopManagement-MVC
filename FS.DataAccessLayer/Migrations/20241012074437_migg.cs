using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FS.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6045), new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 10, 12, 7, 44, 37, 217, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 44, 37, 216, DateTimeKind.Utc).AddTicks(5136), new DateTime(2024, 10, 12, 7, 44, 37, 216, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
