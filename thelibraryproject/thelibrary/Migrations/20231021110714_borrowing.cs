using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    /// <inheritdoc />
    public partial class borrowing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booksborrowed_Users_UsersId",
                table: "Booksborrowed");

            migrationBuilder.DropIndex(
                name: "IX_Booksborrowed_UsersId",
                table: "Booksborrowed");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Booksborrowed");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booksborrowed_Users_UserId",
                table: "Booksborrowed");

            migrationBuilder.DropIndex(
                name: "IX_Booksborrowed_UserId",
                table: "Booksborrowed");

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Booksborrowed",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
