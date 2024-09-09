using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoviesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95884caa-2428-4cfc-943e-ac987fc94330", "AQAAAAIAAYagAAAAEAnLu+TDNR+KNst8WfM/tcbDVdV4pylCDuEeQNostw0S45/7T1bpgEV1oNEAwCJKHg==", "6b8ed6db-4bd7-4eaf-9719-954d3d413f47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7a899e1-76ff-4645-aa3c-ecb4767c1c6d", "AQAAAAIAAYagAAAAEOf8gr9Fdo3ARDeYYxwgGHYyW7G05fkV15XjufdCilkj0IIRZFHBEVL4QzZBxAJImg==", "47817399-34c0-4fc5-b148-9134db9cb5c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23ecda42-c885-494f-9d8e-cb560bb8a6f9", "AQAAAAIAAYagAAAAEAkhSFuuHWOWmGqXBDBJRNXT67xEjfk8CJMp4QoeevUsm+3P/JycUP801LEj9zpQ2A==", "f26ef962-fd9a-4d18-a480-bea70d768508" });

            migrationBuilder.InsertData(
                table: "MoviesStreamings",
                columns: new[] { "MovieId", "StreamingId" },
                values: new object[,]
                {
                    { 44, 4 },
                    { 45, 2 },
                    { 46, 3 },
                    { 47, 1 },
                    { 48, 2 },
                    { 49, 3 },
                    { 50, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 50, 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea21f126-e52c-466d-b941-2665948f9e5e", "AQAAAAIAAYagAAAAECjYVPc2AO5KN2WcCrQy1OInCzdYBhaiq1m8hB07unB+Ulq2exFxpqxaPWysB5cYnw==", "86b0ed23-8e8b-4e8a-af2a-27c206f6f5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cd405ed-bfce-47dc-a01d-c1e17e3343a7", "AQAAAAIAAYagAAAAECDR2G7zpx8GInuncEw7D8usgSS7yabKPde8jHaSiZlB38+uIgZrD4Ax8a5f2vtRMA==", "0154f4ec-decb-48b0-a62e-2a03a65ec4b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e8ac423-3aee-4d31-bb48-0796488e20e1", "AQAAAAIAAYagAAAAEJlevP3MvLsg2aUxKiGoO0R+N9Cz2bzAiirqM2fV8nSXy7V3iY8S7ShQ9yCXK0eiYg==", "37482d5b-4568-442c-afb3-ddd759419587" });

            migrationBuilder.InsertData(
                table: "MoviesStreamings",
                columns: new[] { "MovieId", "StreamingId" },
                values: new object[] { 44, 5 });
        }
    }
}
