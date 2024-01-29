using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8218d50d-d448-495c-92f7-9dd5b1fbc241", "747b97e6-0787-419f-864b-b91284450214" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2e7e4f2-bd92-4be6-85de-aa34a0d8e619", "f670b37b-f1f4-407b-8291-9b5c0882a905" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8218d50d-d448-495c-92f7-9dd5b1fbc241");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e7e4f2-bd92-4be6-85de-aa34a0d8e619");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "747b97e6-0787-419f-864b-b91284450214");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f670b37b-f1f4-407b-8291-9b5c0882a905");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
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
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Pseudonym = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName", "Pseudonym" },
                values: new object[,]
                {
                    { 1, "Dominik", "Matras", "Dominik Matras" },
                    { 2, "Jan", "Kowalski", "Jan Kowalski" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Date" },
                values: new object[] { 1, new DateTime(2024, 1, 28, 9, 59, 0, 220, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Date" },
                values: new object[] { 2, new DateTime(2024, 1, 28, 9, 59, 0, 220, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebb742fe-eca1-4bce-a74a-5eaf82b03bed", "60094ec0-a8e3-4454-86c6-fe8f8d658cfa" },
                    { "14692d19-a4ea-4c54-8782-4a48a78e09ab", "d7045430-7c1f-4228-96a5-e40b6e9c7c21" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AuthorId",
                table: "Photos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Author_AuthorId",
                table: "Photos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Author_AuthorId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Photos_AuthorId",
                table: "Photos");

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Photos",
                type: "TEXT",
                maxLength: 60,
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
                    { "8218d50d-d448-495c-92f7-9dd5b1fbc241", "8218d50d-d448-495c-92f7-9dd5b1fbc241", "admin", "ADMIN" },
                    { "f2e7e4f2-bd92-4be6-85de-aa34a0d8e619", "f2e7e4f2-bd92-4be6-85de-aa34a0d8e619", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "747b97e6-0787-419f-864b-b91284450214", 0, "29c07f55-ba48-4988-a670-c2505e6ab7ba", "dominikmatras@microsoft.wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEAAO6xx+J5LEr+BHOLeMbRV/Fzb41Jnlit2076QFdpwgPTVJdTXOZ9aEZRsrVO/kzg==", null, false, "685665a2-e6ae-4b7c-900e-6affe49fba09", false, "admin" },
                    { "f670b37b-f1f4-407b-8291-9b5c0882a905", 0, "276d709c-9c66-4ed7-a8b0-0055ef231ab5", "user@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEHZ5fTEtxIzcnNW2IxNDgLAVxuPqjsjPUxsD1vdzK56a2/jH7kKFg6uksFs67IvjrQ==", null, false, "7f4395f2-ce0a-4b14-88eb-0c8b5bd2a958", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Date" },
                values: new object[] { "Autor 1", new DateTime(2024, 1, 24, 20, 5, 32, 593, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Date" },
                values: new object[] { "Autor 2", new DateTime(2024, 1, 24, 20, 5, 32, 593, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8218d50d-d448-495c-92f7-9dd5b1fbc241", "747b97e6-0787-419f-864b-b91284450214" },
                    { "f2e7e4f2-bd92-4be6-85de-aa34a0d8e619", "f670b37b-f1f4-407b-8291-9b5c0882a905" }
                });
        }
    }
}
