using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteOrganization2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf31be23-5540-4017-9ab9-6b734688e741", "37023c87-f1c9-412d-b9f6-bdcaa7b58b99" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe5df133-8e19-495a-a562-0abf2427a3e7", "cffdc186-3779-4f71-bd7b-a7c89671929b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf31be23-5540-4017-9ab9-6b734688e741");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe5df133-8e19-495a-a562-0abf2427a3e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37023c87-f1c9-412d-b9f6-bdcaa7b58b99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cffdc186-3779-4f71-bd7b-a7c89671929b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d221476-31b5-4231-aaee-bd80d4c432e1", "0d221476-31b5-4231-aaee-bd80d4c432e1", "admin", "ADMIN" },
                    { "25e2277a-2867-4d40-9b56-7ad377d8d7cf", "25e2277a-2867-4d40-9b56-7ad377d8d7cf", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65508fb1-177b-494a-86fa-e641aa4cc901", 0, "c6678bc3-4e3f-4537-96ec-b64b79c07034", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEDItF4ECCM5BVhPeOwmnpZcLCQyZV0StHp+ey76hms/AiV7psfF/2cwpChxj5FBHCw==", null, false, "15c991bb-577a-40ad-bb59-957633934532", false, "user" },
                    { "759e4556-a21a-4d5b-ab97-33b1c01e05e2", 0, "29f0a578-4e96-4f59-88a9-412b89a273da", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEJ8KJdB36Ns4qx4r1ED9N2HfiXHIiwRpK1NHxPypQ3VmSWFh4ygbHLqn1z59CKTXqQ==", null, false, "eef7ff12-f1eb-4752-a525-a077d3d80130", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 9, 50, 421, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 9, 50, 421, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "25e2277a-2867-4d40-9b56-7ad377d8d7cf", "65508fb1-177b-494a-86fa-e641aa4cc901" },
                    { "0d221476-31b5-4231-aaee-bd80d4c432e1", "759e4556-a21a-4d5b-ab97-33b1c01e05e2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25e2277a-2867-4d40-9b56-7ad377d8d7cf", "65508fb1-177b-494a-86fa-e641aa4cc901" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d221476-31b5-4231-aaee-bd80d4c432e1", "759e4556-a21a-4d5b-ab97-33b1c01e05e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d221476-31b5-4231-aaee-bd80d4c432e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25e2277a-2867-4d40-9b56-7ad377d8d7cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65508fb1-177b-494a-86fa-e641aa4cc901");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "759e4556-a21a-4d5b-ab97-33b1c01e05e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf31be23-5540-4017-9ab9-6b734688e741", "bf31be23-5540-4017-9ab9-6b734688e741", "user", "USER" },
                    { "fe5df133-8e19-495a-a562-0abf2427a3e7", "fe5df133-8e19-495a-a562-0abf2427a3e7", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "37023c87-f1c9-412d-b9f6-bdcaa7b58b99", 0, "c04f8b99-86a1-4dca-9d95-3ed560562c15", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEILoCwyQ1WQ2I+xB3zBnTtFghpWnHMQ3Oao3F4Mv6MX3g0ZlTaARaWVAiP6ixypwPQ==", null, false, "ad5dba70-328d-4ab5-81ef-ce8c6fb4642d", false, "user" },
                    { "cffdc186-3779-4f71-bd7b-a7c89671929b", 0, "129c5c4f-c66c-4d05-bafb-fed144ad61bf", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEJMc08MOibnD9sH2oqZTg6CGuPaDwSRIQ6VWtVpgm6GmIvarE7VlrBJrIuDNPkkVkQ==", null, false, "acc5a413-d746-4e87-84eb-a731351e22a0", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 4, 45, 26, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 4, 45, 26, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bf31be23-5540-4017-9ab9-6b734688e741", "37023c87-f1c9-412d-b9f6-bdcaa7b58b99" },
                    { "fe5df133-8e19-495a-a562-0abf2427a3e7", "cffdc186-3779-4f71-bd7b-a7c89671929b" }
                });
        }
    }
}
