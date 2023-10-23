using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class ReservationandBorrowing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Booksborrowed");

            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Books",
                newName: "IsReserved");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "a8f4f1415b524462a7c11a596214520b");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "fc1605a690e747a1b3d10c5da3123718");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4a3c722-d484-4cf6-9cc1-4b35fb049524", "AQAAAAEAACcQAAAAEMU0U+G3isy9vvMrMd2z2L9a45Bdm+ia04s6+oNwqR0qvP7uLYrCOUJGE/w4K0NptQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "21dbd6fd-19cd-4419-99ef-7745a083d703", new DateTime(2023, 10, 18, 9, 11, 25, 746, DateTimeKind.Utc).AddTicks(4310), "AQAAAAEAACcQAAAAECBqxcwkmprX0Mk9IHeJXIL1EbWSxY63BBGN4LSn7hvA63sK4KQDKva7MlV8Hwri2Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsReserved",
                table: "Books",
                newName: "IsAvailable");

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Booksborrowed",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "41ac42f123214904913125176b0cae62");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "3ff813f58bf34cd58d77d931c8ee001d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a1d6bd6-5daf-4d36-9638-dc8106bfc8d8", "AQAAAAEAACcQAAAAELjn/WJKYuka+X1IoBhFdwweiTE12spiV5CoNsuREzORTJP4+TnWIE8pf4YHbtWfOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "8b89b7c8-d380-4d0d-86a4-ab26cc728761", new DateTime(2023, 10, 16, 18, 10, 43, 878, DateTimeKind.Utc).AddTicks(6567), "AQAAAAEAACcQAAAAEHNAVtT3Nz9ZPlEPuybHi0NFmp4aOwu1HolLwRVh9FqtuachVxV61l5XyWPrzDodaA==" });
        }
    }
}
