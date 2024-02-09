using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteOrganization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Organization_OrganizationId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Photos_OrganizationId",
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
                name: "OrganizationId",
                table: "Photos");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nip = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Address_City = table.Column<string>(type: "TEXT", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
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
                table: "Organization",
                columns: new[] { "Id", "Nip", "Regon", "Title", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[,]
                {
                    { 1, "83492384", "13424234", "WSEI", "Kraków", "31-150", "małopolskie", "Św. Filipa 17" },
                    { 2, "2498534", "0873439249", "Firma", "Kraków", "31-150", "małopolskie", "Krowoderska 45/6" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrganizationId" },
                values: new object[] { new DateTime(2024, 2, 6, 19, 41, 52, 733, DateTimeKind.Local).AddTicks(5770), 1 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrganizationId" },
                values: new object[] { new DateTime(2024, 2, 6, 19, 41, 52, 733, DateTimeKind.Local).AddTicks(5830), 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d67bbb2f-2320-4f0c-96f0-fcd7a0504873", "35e2feef-d14d-456e-bea7-b3906582a172" },
                    { "12598419-91aa-4837-9691-4b798ffa3efa", "c688e267-c8e7-43e1-a699-be38da8db588" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_OrganizationId",
                table: "Photos",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Organization_OrganizationId",
                table: "Photos",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
