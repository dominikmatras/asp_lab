using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteOrganizationschemaupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfcac8ca-05ab-4d58-883e-0c8fd53b7662", "9dbde7a8-7cee-469d-a8ae-33764b53c1ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee136b65-97ff-4747-bd3d-2a99135269e6", "a242cebe-0d81-456b-84b7-5443498ba620" });

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfcac8ca-05ab-4d58-883e-0c8fd53b7662");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee136b65-97ff-4747-bd3d-2a99135269e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dbde7a8-7cee-469d-a8ae-33764b53c1ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a242cebe-0d81-456b-84b7-5443498ba620");

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55977460-23b9-45eb-84ab-ecb9b0ac75bf", "55977460-23b9-45eb-84ab-ecb9b0ac75bf", "admin", "ADMIN" },
                    { "dce34d7f-936d-48d5-a5d2-2675b2c07798", "dce34d7f-936d-48d5-a5d2-2675b2c07798", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c00ca28-8930-4eed-96b2-7bae24d86e4f", 0, "7b34d73f-8da2-474e-99ea-15ff250365d6", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEOtPc0SVSvvaFAM862hsh+3DngflE2EFhzXkCO5//qGGB5qBL8nt1ngA3S55yKCZJQ==", null, false, "213f5c5b-259f-4aeb-956c-fe0e02a34157", false, "user" },
                    { "a29a6ddb-ee04-4f4f-9162-8b07ac25e321", 0, "148e91e7-7517-4892-bc2d-b21078cafeba", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEFmY9d1jUxShnK/lqQ+IE08wFqlVLWgm+Wfkz4vTlwqS8uur/XfIhATF3iNT561dng==", null, false, "afa90846-1755-4c2d-9a9f-85de13a20380", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dce34d7f-936d-48d5-a5d2-2675b2c07798", "7c00ca28-8930-4eed-96b2-7bae24d86e4f" },
                    { "55977460-23b9-45eb-84ab-ecb9b0ac75bf", "a29a6ddb-ee04-4f4f-9162-8b07ac25e321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dce34d7f-936d-48d5-a5d2-2675b2c07798", "7c00ca28-8930-4eed-96b2-7bae24d86e4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55977460-23b9-45eb-84ab-ecb9b0ac75bf", "a29a6ddb-ee04-4f4f-9162-8b07ac25e321" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55977460-23b9-45eb-84ab-ecb9b0ac75bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dce34d7f-936d-48d5-a5d2-2675b2c07798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c00ca28-8930-4eed-96b2-7bae24d86e4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a29a6ddb-ee04-4f4f-9162-8b07ac25e321");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfcac8ca-05ab-4d58-883e-0c8fd53b7662", "dfcac8ca-05ab-4d58-883e-0c8fd53b7662", "admin", "ADMIN" },
                    { "ee136b65-97ff-4747-bd3d-2a99135269e6", "ee136b65-97ff-4747-bd3d-2a99135269e6", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9dbde7a8-7cee-469d-a8ae-33764b53c1ab", 0, "7ea09549-d8ba-490f-bb88-6f1fe5840f07", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEBStjcC/FG8O7wF3Uy/4WiLXuo9EqLNGuC+tvne/vsZZkDIvAdGywGHRuu8T0sAgrA==", null, false, "dfc9572f-6072-4a8c-815a-0f4c1ef4a952", false, "admin" },
                    { "a242cebe-0d81-456b-84b7-5443498ba620", 0, "ec190935-de50-45d9-974a-ee36e291bd8d", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEDpn+vpJ+XYYDoFmyg/nK2mDUnkDBRzMbUqV4GGVoGyfeJJd8quTfbzTT4ph/SE7kg==", null, false, "7f97f1c7-b2b5-4289-9bca-85bdf128382d", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName", "Pseudonym" },
                values: new object[,]
                {
                    { 1, "Dominik", "Matras", "Dominik Matras" },
                    { 2, "Jan", "Kowalski", "Jan Kowalski" }
                });

            migrationBuilder.InsertData(
                table: "Camera",
                columns: new[] { "Id", "Model", "Producer", "SerialNumber" },
                values: new object[,]
                {
                    { 1, "Canon 5D Mark IV", "Canon", "SN12445" },
                    { 2, "Sony A7 III", "Sony", "SN12345" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dfcac8ca-05ab-4d58-883e-0c8fd53b7662", "9dbde7a8-7cee-469d-a8ae-33764b53c1ab" },
                    { "ee136b65-97ff-4747-bd3d-2a99135269e6", "a242cebe-0d81-456b-84b7-5443498ba620" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AspectRatio", "AuthorId", "CameraId", "Created", "Date", "Description", "Priority", "Resolution" },
                values: new object[,]
                {
                    { 1, "16:9", 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 8, 16, 58, 809, DateTimeKind.Local).AddTicks(3090), "Opis zdjęcia 1", 1, "1920x1080" },
                    { 2, "16:9", 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 8, 16, 58, 809, DateTimeKind.Local).AddTicks(3140), "Opis zdjęcia 2", 2, "1920x1080" }
                });
        }
    }
}
