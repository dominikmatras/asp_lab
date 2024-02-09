using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteOrganization3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 16, 58, 809, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 2, 8, 8, 16, 58, 809, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dfcac8ca-05ab-4d58-883e-0c8fd53b7662", "9dbde7a8-7cee-469d-a8ae-33764b53c1ab" },
                    { "ee136b65-97ff-4747-bd3d-2a99135269e6", "a242cebe-0d81-456b-84b7-5443498ba620" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
