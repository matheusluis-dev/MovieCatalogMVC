using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "f85ae5bb-0e29-4839-8c93-09399451f85f", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECWtejQgdLqN+G2DaBrcO9+dvmTDuvrYGFz4QV9IOnwjZP0F4rCQB31r8XXR9RSr/g==", null, false, "7a6bdd33-21f0-401f-992e-1cef8a7f23dc", false, "user1@example.com" },
                    { "2", 0, "9e54edbf-cbca-4f68-96b9-7d7e8b0eae02", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF9urVKA74L0K6H2pjQM2+3F/NzG7EfxyVghlENIAYaRTKrBSBhL2uRzOG+hHk8kxg==", null, false, "b2cc5580-b611-4772-9d99-325c9d5a1b00", false, "user2@example.com" },
                    { "3", 0, "e26a1372-0291-40e7-8409-edd5f02f3ca8", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJRs/A6vw/+SJ8TxM8V4M28stiLZcw7Uw0KCwrAr2xSHDRhpmjX1UqMClI0xMg8n4Q==", null, false, "eeef68be-886b-47f6-b96b-596b531dec3c", false, "user3@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
