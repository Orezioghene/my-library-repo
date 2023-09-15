using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class authentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matric_No",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matric_No",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "93e57558bd7240d899ca43cf429a47e6");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "a91bb6985f154aaabe799e67ad4def61");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60a88695-a015-42db-957f-2a6a9d9f742c", "AQAAAAEAACcQAAAAEH06GCB8zMhxvzlTJDaDdG8mZHbyo41m7JQfSUc9eXCIg2rG8sFCi6bXlBaXP4GvUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "9c9d0490-4202-4961-b41d-8f1ebd336eab", new DateTime(2023, 9, 2, 19, 6, 24, 176, DateTimeKind.Utc).AddTicks(9531), "AQAAAAEAACcQAAAAEMb0J9NdkX1pgZvoWnJB9QBRn7BpSrnuwcGsf5KDO15lm44dzWiaSnCPhJHf+awZUQ==" });
        }
    }
}
