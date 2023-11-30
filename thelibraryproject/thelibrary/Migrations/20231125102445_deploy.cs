using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class deploy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "c2e0e9ff1e8843deb6caa2a2bef567ac");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "06766c007dde4f3198c3bbb79e120b29");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e799b98c-b805-4735-9ec0-7ad750fc67c9", "AQAAAAEAACcQAAAAEI4iqjO+poFdcfaOVuUaz9UCgQJuqxsxz1c2Vs40sLJJM34olAT3seV6JLW7I+3Rjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "f6a2e11f-60c4-455d-88f3-78e07d8e20e0", new DateTime(2023, 11, 25, 10, 24, 45, 161, DateTimeKind.Utc).AddTicks(9453), "AQAAAAEAACcQAAAAEMdWxDeKoP+DXLx2bWLuvx2AA6AN0T2rWVPtFxI/wsahYyX1JCX3+7Xbk/VCe2AuJg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "87fd9684214d462ea0f3c3131540e4b5");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "29d391fe637c4334949623af689abfee");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95ac4219-db10-440e-8bac-1c7b3a903e46", "AQAAAAEAACcQAAAAEHuQJf6ypzTcuAoIQFrp99IL7ZX0LJFSoy35s3fk1H7zkJ8Na48v5JhbxVCRzqPagg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "65739458-2c93-452d-971c-93dd7a19ee21", new DateTime(2023, 11, 10, 19, 21, 26, 191, DateTimeKind.Utc).AddTicks(4899), "AQAAAAEAACcQAAAAEHmP11/VLry4YrMFMRSjz6Tt5Pw3U+HyuluRhvMNaztpXHI+zque3GuGYGtrOi5rxw==" });
        }
    }
}
