using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedStreamings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Streamings",
                columns: new[] { "StreamingId", "Name" },
                values: new object[,]
                {
                    { 1, "Netflix" },
                    { 2, "Amazon Prime Video" },
                    { 3, "Disney+" },
                    { 4, "HBO Max" },
                    { 5, "Hulu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Streamings",
                keyColumn: "StreamingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Streamings",
                keyColumn: "StreamingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Streamings",
                keyColumn: "StreamingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Streamings",
                keyColumn: "StreamingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Streamings",
                keyColumn: "StreamingId",
                keyValue: 5);
        }
    }
}
