using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addOrganizationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<string>(type: "TEXT", nullable: false),
                    Nip = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street", "Nip", "Regon", "Title" },
                values: new object[,]
                {
                    { 1, "Kraków", "31-150", "małopolskie", "Św. Filipa 17", "83492384", "13424234", "WSEI" },
                    { 2, "Kraków", "31-150", "małopolskie", "Krowoderska 45/6", "2498534", "0873439249", "Firma" }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrganizationId" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 10, 10, 537, DateTimeKind.Local).AddTicks(6140), 1 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrganizationId" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 10, 10, 537, DateTimeKind.Local).AddTicks(6190), 2 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Organization_OrganizationId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Photos_OrganizationId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Photos");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 20, 15, 24, 37, 641, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 20, 15, 24, 37, 641, DateTimeKind.Local).AddTicks(2000));
        }
    }
}
