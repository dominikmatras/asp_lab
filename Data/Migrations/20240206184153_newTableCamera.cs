using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class newTableCamera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "183b979d-5232-4f45-93aa-aeb5ef0e4f3a", "65654a02-27d8-4848-9d8b-cde31ed62cb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1b214a7-b51e-4d52-a024-d5972163b9a5", "9fd88ade-40db-43ec-9dd7-23398daf09af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "183b979d-5232-4f45-93aa-aeb5ef0e4f3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b214a7-b51e-4d52-a024-d5972163b9a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65654a02-27d8-4848-9d8b-cde31ed62cb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fd88ade-40db-43ec-9dd7-23398daf09af");

            migrationBuilder.DropColumn(
                name: "Camera",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "CameraId",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Organization",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Producer = table.Column<string>(type: "TEXT", nullable: true),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12598419-91aa-4837-9691-4b798ffa3efa", "12598419-91aa-4837-9691-4b798ffa3efa", "admin", "ADMIN" },
                    { "d67bbb2f-2320-4f0c-96f0-fcd7a0504873", "d67bbb2f-2320-4f0c-96f0-fcd7a0504873", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35e2feef-d14d-456e-bea7-b3906582a172", 0, "ac40f4c5-42bc-4a4e-b93b-b84a062f7bde", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEA5rAH7kkj6qMDJibG8125uAA6y4I2q8ptP3Flkgiu+FtW0bV4yR+TO8NSI+cxUIQQ==", null, false, "cf379044-4b0c-455d-92c7-e8bb407da108", false, "user" },
                    { "c688e267-c8e7-43e1-a699-be38da8db588", 0, "79690021-0308-4fa7-8ec8-a38eb4afdd42", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEDXEoEWJ1FC5gQgyo+fw/qJZt9k7SPJC1r1n9nqwQDyfpB8OJDgs9HZGvftxC8mDZQ==", null, false, "9a06e7e4-e6f2-400d-b5e1-6447cd41b208", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Camera",
                columns: new[] { "Id", "Model", "Producer", "SerialNumber" },
                values: new object[,]
                {
                    { 1, "Canon 5D Mark IV", "Canon", "SN12445" },
                    { 2, "Sony A7 III", "Sony", "SN12345" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CameraId", "Date" },
                values: new object[] { 1, new DateTime(2024, 2, 6, 19, 41, 52, 733, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CameraId", "Date" },
                values: new object[] { 2, new DateTime(2024, 2, 6, 19, 41, 52, 733, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d67bbb2f-2320-4f0c-96f0-fcd7a0504873", "35e2feef-d14d-456e-bea7-b3906582a172" },
                    { "12598419-91aa-4837-9691-4b798ffa3efa", "c688e267-c8e7-43e1-a699-be38da8db588" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CameraId",
                table: "Photos",
                column: "CameraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Camera_CameraId",
                table: "Photos",
                column: "CameraId",
                principalTable: "Camera",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Camera_CameraId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Camera");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CameraId",
                table: "Photos");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d67bbb2f-2320-4f0c-96f0-fcd7a0504873", "35e2feef-d14d-456e-bea7-b3906582a172" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12598419-91aa-4837-9691-4b798ffa3efa", "c688e267-c8e7-43e1-a699-be38da8db588" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12598419-91aa-4837-9691-4b798ffa3efa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d67bbb2f-2320-4f0c-96f0-fcd7a0504873");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e2feef-d14d-456e-bea7-b3906582a172");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c688e267-c8e7-43e1-a699-be38da8db588");

            migrationBuilder.DropColumn(
                name: "CameraId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Camera",
                table: "Photos",
                type: "TEXT",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Organization",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "183b979d-5232-4f45-93aa-aeb5ef0e4f3a", "183b979d-5232-4f45-93aa-aeb5ef0e4f3a", "user", "USER" },
                    { "e1b214a7-b51e-4d52-a024-d5972163b9a5", "e1b214a7-b51e-4d52-a024-d5972163b9a5", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65654a02-27d8-4848-9d8b-cde31ed62cb3", 0, "99037b93-27ab-4f65-bba5-efb38e0c94b3", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEAfD2MwkUTN470SY4M83737kXsms0WUB6KdH/HwZSzldWJq/5aigjwFeH+9BWHbpgQ==", null, false, "a2c1993b-ab4e-44f5-bdf3-b9aaa2f32c3f", false, "user" },
                    { "9fd88ade-40db-43ec-9dd7-23398daf09af", 0, "af86ea98-7783-433b-9357-c9a5eb9766e8", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEOlmW5rHPpvUs3RBIC6AHNUToscUt4/NHzDHNYCgMJA0//S427smPBlkrBnt9mvb0A==", null, false, "9b74f655-9d20-4a15-a88c-2c70d6941f0b", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Camera", "Date" },
                values: new object[] { "Aparat 1", new DateTime(2024, 1, 31, 15, 35, 9, 525, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Camera", "Date" },
                values: new object[] { "Aparat 2", new DateTime(2024, 1, 31, 15, 35, 9, 525, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "183b979d-5232-4f45-93aa-aeb5ef0e4f3a", "65654a02-27d8-4848-9d8b-cde31ed62cb3" },
                    { "e1b214a7-b51e-4d52-a024-d5972163b9a5", "9fd88ade-40db-43ec-9dd7-23398daf09af" }
                });
        }
    }
}
