using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteOrganizationdataInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "44f596ac-c036-4b91-b84a-112e500a82f3", "44f596ac-c036-4b91-b84a-112e500a82f3", "user", "USER" },
                    { "ddcf063a-86d4-437c-b2fb-a1d3b5f5774a", "ddcf063a-86d4-437c-b2fb-a1d3b5f5774a", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b519424-1f2e-4427-a447-750557a1132a", 0, "efb68d22-54af-43dc-a697-79a0b0e36718", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEO/3YKR46NzNflJjRgqPc4XyXufRpq6b+yrtl6PeSV5HR9vlQKWwSvooJ7KX91r2Ug==", null, false, "15c15ba1-3651-41c4-9bd0-7f06a07a2dc0", false, "user" },
                    { "c80604e9-e3ed-48f9-b420-bae7de7c54c1", 0, "88a864b3-2195-47a3-aef8-1633335ba81f", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEL7GF4DZ3dMgHniYPs8f+YWO/n/MnoxcGDzKAVC7BRWjsnYQbDnF8o8gfeDrJ4tGCQ==", null, false, "51e2ac30-1a3e-4dce-a87b-2f4778100454", false, "admin" }
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
                    { "44f596ac-c036-4b91-b84a-112e500a82f3", "8b519424-1f2e-4427-a447-750557a1132a" },
                    { "ddcf063a-86d4-437c-b2fb-a1d3b5f5774a", "c80604e9-e3ed-48f9-b420-bae7de7c54c1" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AspectRatio", "AuthorId", "CameraId", "Created", "Date", "Description", "Priority", "Resolution" },
                values: new object[,]
                {
                    { 1, "16:9", 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 8, 23, 11, 79, DateTimeKind.Local).AddTicks(9750), "Opis zdjęcia 1", 1, "1920x1080" },
                    { 2, "16:9", 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 8, 23, 11, 79, DateTimeKind.Local).AddTicks(9810), "Opis zdjęcia 2", 2, "1920x1080" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44f596ac-c036-4b91-b84a-112e500a82f3", "8b519424-1f2e-4427-a447-750557a1132a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddcf063a-86d4-437c-b2fb-a1d3b5f5774a", "c80604e9-e3ed-48f9-b420-bae7de7c54c1" });

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
                keyValue: "44f596ac-c036-4b91-b84a-112e500a82f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddcf063a-86d4-437c-b2fb-a1d3b5f5774a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b519424-1f2e-4427-a447-750557a1132a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80604e9-e3ed-48f9-b420-bae7de7c54c1");

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
    }
}
