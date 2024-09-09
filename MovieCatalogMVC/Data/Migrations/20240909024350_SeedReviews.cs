using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d5359e-092e-4bb6-a229-2eea2b23886a", "AQAAAAIAAYagAAAAEBARLLbdHUurat7gsrKdk133i3ockXCRze9/UgZAfLNViMyQUFmRlvikuR4sC62XKQ==", "acb7e91d-fa8e-4afc-b081-0b4a258b3f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cae9434-a352-4f52-a414-4353c5a20231", "AQAAAAIAAYagAAAAEBvhG5T/BOTA6VKGmReh3cURyG3tz9YNwHqkuKDOL/iz66Wwe43/HImWCS/7H4N8SQ==", "50910133-18d0-466f-ac68-b8982d918f6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "026c3554-4ab1-4d52-b57a-1f45e2101704", "AQAAAAIAAYagAAAAEHEr4Se19ZoX2eYc4IdKia7wZnH7sth17vFN9yDvS8j9ztdbk+F9IHg2JVsU4zglOA==", "e74d5eea-530c-48c9-aae6-4b161120c74e" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "MovieId", "Rate", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { -2042504858, "Would not recommend.", 41, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(188), "1" },
                    { -1998793611, "Really enjoyed it.", 6, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8149), "1" },
                    { -1934488938, "Would not recommend.", 35, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9885), "3" },
                    { -1864001702, "Not bad, but could be better.", 22, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9237), "1" },
                    { -1801038450, "A masterpiece!", 37, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9979), "2" },
                    { -1668367387, "", 33, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9768), "3" },
                    { -1571687970, "", 10, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8358), "2" },
                    { -1532410608, "A masterpiece!", 42, 1, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(211), "2" },
                    { -1355269795, "Really enjoyed it.", 40, 3, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(118), "3" },
                    { -1352240908, "", 23, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9260), "2" },
                    { -1271345463, "Not bad, but could be better.", 32, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9745), "1" },
                    { -1261472015, "Great movie!", 2, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7613), "3" },
                    { -1215688623, "Not bad, but could be better.", 43, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(280), "1" },
                    { -1181304867, "Not bad, but could be better.", 21, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9169), "2" },
                    { -1149159625, "Not bad, but could be better.", 23, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9283), "1" },
                    { -1032801216, "", 31, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9674), "3" },
                    { -915048420, "", 38, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(24), "3" },
                    { -911101101, "Would not recommend.", 21, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9192), "1" },
                    { -902496200, "Not bad, but could be better.", 1, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7522), "2" },
                    { -896650129, "Would not recommend.", 34, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9839), "1" },
                    { -865821447, "", 24, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9331), "2" },
                    { -811296574, "Not bad, but could be better.", 41, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(164), "3" },
                    { -698299737, "Great movie!", 39, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(92), "2" },
                    { -688167549, "A masterpiece!", 24, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9308), "2" },
                    { -681301126, "", 30, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9651), "3" },
                    { -662180432, "Great movie!", 29, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9599), "1" },
                    { -543996011, "", 46, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(398), "2" },
                    { -531583901, "Not bad, but could be better.", 50, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(583), "1" },
                    { -456468176, "Really enjoyed it.", 28, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9553), "1" },
                    { -434733164, "Not bad, but could be better.", 31, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9697), "2" },
                    { -428953596, "A masterpiece!", 34, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9816), "1" },
                    { -363991299, "Really enjoyed it.", 48, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(514), "2" },
                    { -339852750, "A masterpiece!", 1, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(206), "2" },
                    { -326985556, "", 39, 3, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(47), "2" },
                    { -322139031, "Not bad, but could be better.", 35, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9862), "2" },
                    { -305036750, "Great movie!", 45, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(353), "1" },
                    { -303744426, "Not bad, but could be better.", 14, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8707), "2" },
                    { -295109688, "A masterpiece!", 26, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9423), "1" },
                    { -293836472, "", 46, 4, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(421), "2" },
                    { -247395953, "Would not recommend.", 15, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8841), "3" },
                    { -184998244, "Really enjoyed it.", 37, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9956), "1" },
                    { -173752191, "A masterpiece!", 25, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9354), "3" },
                    { -165260580, "Really enjoyed it.", 3, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7767), "2" },
                    { -143778457, "A masterpiece!", 18, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9052), "1" },
                    { -124558288, "Not bad, but could be better.", 14, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8736), "1" },
                    { -3618904, "Great movie!", 13, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8600), "2" },
                    { 18987959, "Really enjoyed it.", 5, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7989), "1" },
                    { 22501509, "Not bad, but could be better.", 32, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9723), "3" },
                    { 104483586, "Great movie!", 25, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9377), "1" },
                    { 135134003, "Great movie!", 47, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(467), "2" },
                    { 174216490, "", 40, 4, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(141), "2" },
                    { 198681206, "Really enjoyed it.", 17, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9006), "3" },
                    { 206877958, "Would not recommend.", 44, 1, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(330), "1" },
                    { 226730468, "Really enjoyed it.", 3, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7830), "2" },
                    { 236646209, "Would not recommend.", 49, 3, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(537), "3" },
                    { 238171546, "Really enjoyed it.", 45, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(375), "3" },
                    { 349547201, "", 19, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9075), "3" },
                    { 391451384, "", 27, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9446), "1" },
                    { 431068365, "A masterpiece!", 13, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8473), "3" },
                    { 490993528, "", 11, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8381), "1" },
                    { 592904769, "Would not recommend.", 30, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9628), "3" },
                    { 683695248, "", 22, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9215), "2" },
                    { 720598744, "Not bad, but could be better.", 17, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8981), "3" },
                    { 730658803, "Not bad, but could be better.", 8, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8264), "1" },
                    { 742930797, "", 16, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8959), "3" },
                    { 747592718, "", 38, 4, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(1), "1" },
                    { 805678142, "Would not recommend.", 10, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8335), "3" },
                    { 863746379, "Not bad, but could be better.", 50, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(606), "3" },
                    { 951340184, "Really enjoyed it.", 26, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9400), "2" },
                    { 954504254, "Not bad, but could be better.", 29, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9577), "1" },
                    { 980995106, "A masterpiece!", 48, 4, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(492), "3" },
                    { 987024461, "Great movie!", 5, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8018), "1" },
                    { 1006778750, "Not bad, but could be better.", 33, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9793), "1" },
                    { 1038395819, "Really enjoyed it.", 12, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8450), "2" },
                    { 1068947443, "A masterpiece!", 44, 1, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(306), "1" },
                    { 1105735894, "", 4, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7933), "1" },
                    { 1170636328, "Really enjoyed it.", 19, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9097), "1" },
                    { 1251031982, "Great movie!", 7, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8200), "3" },
                    { 1275479114, "Really enjoyed it.", 8, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8227), "2" },
                    { 1309291082, "Would not recommend.", 2, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7578), "1" },
                    { 1351712131, "Not bad, but could be better.", 9, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8288), "1" },
                    { 1376927856, "A masterpiece!", 20, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9146), "2" },
                    { 1404089802, "Would not recommend.", 4, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(7966), "3" },
                    { 1447058069, "Great movie!", 15, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8883), "2" },
                    { 1450012408, "Really enjoyed it.", 42, 5, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(234), "3" },
                    { 1480694261, "", 18, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9029), "1" },
                    { 1483896213, "A masterpiece!", 28, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9530), "2" },
                    { 1496018839, "Would not recommend.", 7, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8177), "1" },
                    { 1538926406, "A masterpiece!", 49, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(560), "1" },
                    { 1544443931, "", 43, 2, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(257), "3" },
                    { 1593036289, "", 16, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8934), "3" },
                    { 1770342286, "A masterpiece!", 36, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9933), "1" },
                    { 1796965965, "Great movie!", 47, 1, new DateTime(2024, 9, 8, 23, 43, 50, 124, DateTimeKind.Local).AddTicks(444), "2" },
                    { 1910664838, "Great movie!", 36, 3, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9910), "3" },
                    { 1937613530, "Really enjoyed it.", 27, 2, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9468), "2" },
                    { 1967455870, "Not bad, but could be better.", 9, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8311), "3" },
                    { 1985152183, "Would not recommend.", 6, 5, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8048), "2" },
                    { 2042299912, "Would not recommend.", 11, 4, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8403), "3" },
                    { 2089587694, "Would not recommend.", 12, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(8428), "1" },
                    { 2096000787, "Really enjoyed it.", 20, 1, new DateTime(2024, 9, 8, 23, 43, 50, 123, DateTimeKind.Local).AddTicks(9123), "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -2042504858);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1998793611);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1934488938);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1864001702);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1801038450);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1668367387);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1571687970);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1532410608);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1355269795);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1352240908);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1271345463);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1261472015);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1215688623);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1181304867);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1149159625);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1032801216);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -915048420);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -911101101);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -902496200);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -896650129);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -865821447);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -811296574);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -698299737);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -688167549);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -681301126);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -662180432);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -543996011);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -531583901);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -456468176);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -434733164);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -428953596);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -363991299);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -339852750);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -326985556);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -322139031);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -305036750);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -303744426);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -295109688);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -293836472);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -247395953);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -184998244);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -173752191);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -165260580);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -143778457);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -124558288);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -3618904);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18987959);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 22501509);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 104483586);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 135134003);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 174216490);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 198681206);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 206877958);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 226730468);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 236646209);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 238171546);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 349547201);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 391451384);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 431068365);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 490993528);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 592904769);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 683695248);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 720598744);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 730658803);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 742930797);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 747592718);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 805678142);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 863746379);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 951340184);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 954504254);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 980995106);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 987024461);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1006778750);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1038395819);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1068947443);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1105735894);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1170636328);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1251031982);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1275479114);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1309291082);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1351712131);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1376927856);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1404089802);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1447058069);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1450012408);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1480694261);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1483896213);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1496018839);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1538926406);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1544443931);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1593036289);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1770342286);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1796965965);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1910664838);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1937613530);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1967455870);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1985152183);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2042299912);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2089587694);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2096000787);

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
        }
    }
}
