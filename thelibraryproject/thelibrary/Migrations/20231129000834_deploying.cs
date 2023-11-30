using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thelibrary.Migrations
{
    public partial class deploying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "6e64cbca9be94e24ab9bf3af1f350a97");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "d1b4713297eb4b6082ea5b33dda3ee03");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57d3b9a9-b8d6-4072-9445-51eef3159e72", "AQAAAAEAACcQAAAAEG/C0yuarlrYI0MJH/zAcYuTVZJotmh/o+cMTDOjTZeeX4jbp+dDXyiS3gQeGe/l7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "50689435-a9bd-4d00-984c-f3f50619fb79", new DateTime(2023, 11, 29, 0, 8, 34, 152, DateTimeKind.Utc).AddTicks(893), "AQAAAAEAACcQAAAAEAzNqdNKyOhMRjgys/ZViyO9xBW6SGtYRKAX8kmcdwCylh1TgDRJ40x//+YedFYl9w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e4d8a66-0c87-4e58-a6f8-0bde16a24321"),
                column: "ConcurrencyStamp",
                value: "c2e0e9ff1e8843deb6caa2a2bef567ac");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("febb742d-f5db-4ca8-b596-59f3640386fd"),
                column: "ConcurrencyStamp",
                value: "06766c007dde4f3198c3bbb79e120b29");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51f5dd1-0aaa-4542-9683-12591047e74b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e799b98c-b805-4735-9ec0-7ad750fc67c9", "AQAAAAEAACcQAAAAEI4iqjO+poFdcfaOVuUaz9UCgQJuqxsxz1c2Vs40sLJJM34olAT3seV6JLW7I+3Rjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1c52070-dcfe-44cc-bdda-a2426b817174"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "f6a2e11f-60c4-455d-88f3-78e07d8e20e0", new DateTime(2023, 11, 25, 10, 24, 45, 161, DateTimeKind.Utc).AddTicks(9453), "AQAAAAEAACcQAAAAEMdWxDeKoP+DXLx2bWLuvx2AA6AN0T2rWVPtFxI/wsahYyX1JCX3+7Xbk/VCe2AuJg==" });
        }
    }
}
