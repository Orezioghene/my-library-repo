using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class reservationexpired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "81a6f43e56484c6a9338400ac72af947");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "3f2b89a20f98404ea7bd3e650b294b5f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32c7e070-58f6-4422-859a-d3fc51e33500", "AQAAAAEAACcQAAAAEJ23WLaNu1GlrPnjxBSdoqmLPQVn7m81G2c5OJYQKnNPhYed9tQjbs9toTBbu5jJMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "a0d7c411-ad40-49eb-82e3-38f67d1eef57", new DateTime(2023, 10, 21, 11, 7, 13, 873, DateTimeKind.Utc).AddTicks(6816), "AQAAAAEAACcQAAAAEN6ysxCmoXEsO27Waizg7doAAQtgW/YrfsbQrCC4A4Hpit2jJmpPtpwFBuEVS5/K+Q==" });
        }
    }
}
