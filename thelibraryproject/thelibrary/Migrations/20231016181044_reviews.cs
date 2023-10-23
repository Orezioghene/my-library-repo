using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booksborrowed_Users_UserId",
                table: "Booksborrowed");

            migrationBuilder.DropIndex(
                name: "IX_Booksborrowed_UserId",
                table: "Booksborrowed");

            migrationBuilder.DropColumn(
                name: "BookStatus",
                table: "Booksborrowed");

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Booksborrowed",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Booksborrowed",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Books",
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

            migrationBuilder.CreateIndex(
                name: "IX_Booksborrowed_UsersId",
                table: "Booksborrowed",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booksborrowed_Users_UsersId",
                table: "Booksborrowed",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booksborrowed_Users_UsersId",
                table: "Booksborrowed");

            migrationBuilder.DropIndex(
                name: "IX_Booksborrowed_UsersId",
                table: "Booksborrowed");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Booksborrowed");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Booksborrowed");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookStatus",
                table: "Booksborrowed",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Booksborrowed_UserId",
                table: "Booksborrowed",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booksborrowed_Users_UserId",
                table: "Booksborrowed",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
