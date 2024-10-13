using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FS.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RelativePath",
                table: "UploadedFiles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "UploadedFiles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "UploadedFiles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8266), new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8268), new DateTime(2024, 10, 13, 14, 34, 52, 915, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 34, 52, 914, DateTimeKind.Utc).AddTicks(1918), new DateTime(2024, 10, 13, 14, 34, 52, 914, DateTimeKind.Utc).AddTicks(1920) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RelativePath",
                table: "UploadedFiles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "UploadedFiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "UploadedFiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
        }
    }
}
