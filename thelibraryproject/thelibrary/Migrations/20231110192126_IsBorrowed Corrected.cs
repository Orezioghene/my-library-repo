using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class IsBorrowedCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "Booksborrowed");

            migrationBuilder.AddColumn<bool>(
                name: "IsBorrowed",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "IsBorrowed",
                table: "Booksborrowed",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "81861e170afb41a2a846b43d5e285685");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "90ebb7e38526490e8e2cc4f2da8acc70");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ffc229c-b3db-4115-bd6f-09cbb166ad73", "AQAAAAEAACcQAAAAEHwqMWPWwpRoSCOZU+P+xqzJ6fYenwtsA1VtXjqamNvo+HWfRo9A0mSAZn/ajZxkfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "423e3bc3-4136-42c9-b489-22c9b803453d", new DateTime(2023, 11, 10, 18, 44, 45, 927, DateTimeKind.Utc).AddTicks(4696), "AQAAAAEAACcQAAAAEBTKUaACxVS8dm1xKLM9guUGnPtArTispbwBW2VM8uX2nMYwah/zf8SCoAgTTjMbfA==" });
        }
    }
}
