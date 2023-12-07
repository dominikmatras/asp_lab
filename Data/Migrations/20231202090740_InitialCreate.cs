using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Camera = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Author = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Resolution = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    AspectRatio = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AspectRatio", "Author", "Camera", "Created", "Date", "Description", "Priority", "Resolution" },
                values: new object[,]
                {
                    { 1, "16:9", "Autor 1", "Aparat 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 2, 10, 7, 40, 611, DateTimeKind.Local).AddTicks(1990), "Opis zdjęcia 1", 1, "1920x1080" },
                    { 2, "16:9", "Autor 2", "Aparat 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 2, 10, 7, 40, 611, DateTimeKind.Local).AddTicks(2060), "Opis zdjęcia 2", 2, "1920x1080" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
