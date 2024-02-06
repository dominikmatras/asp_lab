using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebb742fe-eca1-4bce-a74a-5eaf82b03bed", "60094ec0-a8e3-4454-86c6-fe8f8d658cfa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14692d19-a4ea-4c54-8782-4a48a78e09ab", "d7045430-7c1f-4228-96a5-e40b6e9c7c21" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14692d19-a4ea-4c54-8782-4a48a78e09ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebb742fe-eca1-4bce-a74a-5eaf82b03bed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60094ec0-a8e3-4454-86c6-fe8f8d658cfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7045430-7c1f-4228-96a5-e40b6e9c7c21");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Organization",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

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
                column: "Date",
                value: new DateTime(2024, 1, 31, 15, 35, 9, 525, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 31, 15, 35, 9, 525, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "183b979d-5232-4f45-93aa-aeb5ef0e4f3a", "65654a02-27d8-4848-9d8b-cde31ed62cb3" },
                    { "e1b214a7-b51e-4d52-a024-d5972163b9a5", "9fd88ade-40db-43ec-9dd7-23398daf09af" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "14692d19-a4ea-4c54-8782-4a48a78e09ab", "14692d19-a4ea-4c54-8782-4a48a78e09ab", "admin", "ADMIN" },
                    { "ebb742fe-eca1-4bce-a74a-5eaf82b03bed", "ebb742fe-eca1-4bce-a74a-5eaf82b03bed", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60094ec0-a8e3-4454-86c6-fe8f8d658cfa", 0, "90b08a7f-c3c3-46cf-9592-7297ed987954", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEDf3aIFYSbbK8RA4UxluBJG+UezDBiBCGB/85O7ayzkoJb2WxPnR5KJHem4th7hzmg==", null, false, "1e60c41e-7c40-4058-992d-dfb1489382f1", false, "user" },
                    { "d7045430-7c1f-4228-96a5-e40b6e9c7c21", 0, "452d6d9e-273a-444e-9ad4-ddab038aa6bb", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAELKtjYQo4Kmwt3V6xrpdboiFbGBMoltkTTcO6cLMnWcrJnrdstqtfwFt8B/D331qTw==", null, false, "2cb14ad9-5702-4e5a-9bac-485908aa81b3", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 28, 9, 59, 0, 220, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 28, 9, 59, 0, 220, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebb742fe-eca1-4bce-a74a-5eaf82b03bed", "60094ec0-a8e3-4454-86c6-fe8f8d658cfa" },
                    { "14692d19-a4ea-4c54-8782-4a48a78e09ab", "d7045430-7c1f-4228-96a5-e40b6e9c7c21" }
                });
        }
    }
}
