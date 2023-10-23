using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "0126ac66f8e644f9b241cf9d9385a59b");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "35bbb6be56fe484dae66493ddeb13b03");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f535361-3785-4a5c-9fe7-afa84b70611f", "AQAAAAEAACcQAAAAEDTftn9Cc1KRFwXQISqVbTAKa31G5GpsaEEVZOAicM3aCzeE31TbrPlN0ZY97OEz5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "8db7cb97-6cfb-4de2-8b8d-3cb575c9b295", new DateTime(2023, 9, 18, 19, 37, 48, 759, DateTimeKind.Utc).AddTicks(9790), "AQAAAAEAACcQAAAAECYO3n4+Y2iMSwTzzL5pUtlj2QrQfeMojHC20toXLsw/psKQ/AvS7tuVa43w75AIJQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "5824a232dd0c47bd8f6306a879bc6bdd");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "52e8776d327a432c9e4979c820679ea7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34261464-ac71-4c2c-86d3-82fc5de35213", "AQAAAAEAACcQAAAAEBIgWQpPEt4t/BZz3I8J5Y1DZhV5KfyKYz7ssA2PSTHl20PTvqyIpXpbNB2ufYa5/g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "dd6e7701-f06b-4811-bf04-104db1e50c85", new DateTime(2023, 9, 18, 19, 23, 48, 741, DateTimeKind.Utc).AddTicks(3372), "AQAAAAEAACcQAAAAEFRi+k9YknJL5MRBgBJt/WE3ebKI3S5ROATHXb5x+do7qr/WLE1Q0QgVbZ8Zra6O3w==" });
        }
    }
}
