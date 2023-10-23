using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class Reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matric_No",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BookStatus",
                table: "BookReservations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Matric_No",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookStatus",
                table: "BookReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "874e7b921c7048378c89a6a15016ae16");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "45d5e23b2d214007bd01943fd4abb1d6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "Matric_No", "PasswordHash" },
                values: new object[] { "d3f00bdc-45ab-4bb4-9c0e-c8f587e87c4e", null, "AQAAAAEAACcQAAAAEKDziTSvmfvf7CZZ4rxjWxMZGoKQZX8xRkegZOOWo9Xczq2Q5A7DtUy/tSMZwc4tCQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "Matric_No", "PasswordHash" },
                values: new object[] { "5e88e53f-d8a0-4136-a138-9179fe927068", new DateTime(2023, 9, 10, 16, 33, 21, 279, DateTimeKind.Utc).AddTicks(6163), null, "AQAAAAEAACcQAAAAEHESJEz+mF+bA1IVY2QUzC3ML2VzZLbbSrDCKpeHkqsVwCMlnxeEbzooGS8W4eVRuQ==" });
        }
    }
}
