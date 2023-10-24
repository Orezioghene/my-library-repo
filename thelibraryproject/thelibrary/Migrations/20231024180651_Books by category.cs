using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class Booksbycategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "52cd61b90b1e44e5a83d28015ad661a7");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "6da91163f82645ddb2a989d89e2b85e2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07a0cdf3-ac49-43d3-83c5-95ad827231a2", "AQAAAAEAACcQAAAAEPy+n1Ubb6ZbxDdILxVfPWP1e+yCAd+JwRvJxhBapdHA7RAOZaAQuuNsqm7ajmpKrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "63dc3b67-4187-43f5-b8b9-a4f233f66951", new DateTime(2023, 10, 23, 9, 44, 1, 92, DateTimeKind.Utc).AddTicks(4408), "AQAAAAEAACcQAAAAEFzCCmCea/dtr6coXB8vLuHoXhugoR7CLHzKPKs2CrxtO66mlb7qk9O7S0hGVuuBWA==" });
        }
    }
}
