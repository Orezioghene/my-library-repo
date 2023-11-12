using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class IsBorrowed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "Booksborrowed");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "be8faf2d9fa24f1bbb3c1e1caa03dcf2");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "acd40f59995b415ca76692d795a38832");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "107fa5b2-1f79-4a11-8983-42355bf8af2f", "AQAAAAEAACcQAAAAEIjd10WWHPgOnrtQNlA4RBDFT0A2qu9Xj71BR0M0aOLJUnT1AIh8s1RmAilQAwhKwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "1a468d27-0368-4d02-abf1-24af968ec298", new DateTime(2023, 10, 24, 18, 6, 51, 365, DateTimeKind.Utc).AddTicks(3813), "AQAAAAEAACcQAAAAEP+g+zSRt3iXDQvDFJ3IwxHClI2jv0IjW81vprcWTbGu9fO04vIpOSz2VI+L5MondQ==" });
        }
    }
}
