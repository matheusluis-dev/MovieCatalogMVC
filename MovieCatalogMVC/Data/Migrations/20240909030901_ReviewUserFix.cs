using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReviewUserFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

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
                values: new object[] { "c2044697-286c-48cb-bba3-d8c9991eddb6", "AQAAAAIAAYagAAAAEORDqxl9Bi655N0GAnL0GMhqgOJxX06t/QM0wtkmzQo8aELeY++3XWpUb2Kajy+r2A==", "d3ad413b-4dbf-4fa1-adac-73e855dac76d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a21c5bb3-cefa-4bff-8345-e1354f991709", "AQAAAAIAAYagAAAAEBqduzW0FDe+DjvCaVYFHe4JNIhoLYrdbzXfSm3JYztEXmNXCdv956MA2BrWaNi6/w==", "042563de-f743-44a1-9ba7-321f6e7914f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a1e35a-2e74-4df5-bf03-435dfe99fa67", "AQAAAAIAAYagAAAAEGy5AIUzA/t5kfrlEi//2+SbMRfiFiSOEGzQsW36bk9NfhNngHZG160OH3P16Zk0Pw==", "b6c650ae-70c7-41cf-8a77-22fb666a5774" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "MovieId", "Rate", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { -2114253428, "", 14, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1108), "1" },
                    { -2098329563, "Not bad, but could be better.", 15, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1168), "1" },
                    { -2020048327, "A masterpiece!", 4, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(478), "2" },
                    { -1998371247, "Really enjoyed it.", 18, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1366), "2" },
                    { -1949664316, "A masterpiece!", 1, 4, new DateTime(2024, 9, 9, 0, 9, 1, 40, DateTimeKind.Local).AddTicks(4295), "3" },
                    { -1901508636, "Would not recommend.", 5, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(591), "1" },
                    { -1897899896, "Not bad, but could be better.", 13, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1010), "1" },
                    { -1845699736, "A masterpiece!", 6, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(647), "2" },
                    { -1805598415, "Great movie!", 22, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1560), "3" },
                    { -1717745230, "Would not recommend.", 37, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2303), "2" },
                    { -1606702394, "Really enjoyed it.", 24, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1682), "2" },
                    { -1569710433, "A masterpiece!", 35, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2232), "2" },
                    { -1503281918, "Not bad, but could be better.", 21, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1537), "1" },
                    { -1419506644, "Really enjoyed it.", 15, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1203), "1" },
                    { -1409578747, "Great movie!", 17, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1288), "3" },
                    { -1381376148, "Great movie!", 24, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1658), "3" },
                    { -1378549022, "A masterpiece!", 9, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(842), "2" },
                    { -1350271445, "A masterpiece!", 23, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1610), "1" },
                    { -1315666479, "Really enjoyed it.", 5, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(525), "2" },
                    { -1257468117, "", 16, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1238), "1" },
                    { -1172892621, "A masterpiece!", 41, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2520), "2" },
                    { -1109671825, "Not bad, but could be better.", 11, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(940), "3" },
                    { -1084293906, "Great movie!", 46, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2803), "2" },
                    { -1078423083, "Would not recommend.", 12, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(987), "1" },
                    { -985339848, "Not bad, but could be better.", 39, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2424), "3" },
                    { -977117385, "Not bad, but could be better.", 23, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1634), "2" },
                    { -896715856, "Would not recommend.", 33, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2109), "1" },
                    { -885465714, "Would not recommend.", 42, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2543), "2" },
                    { -884179571, "Really enjoyed it.", 33, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2136), "3" },
                    { -880967854, "A masterpiece!", 8, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(792), "2" },
                    { -755467274, "Really enjoyed it.", 14, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1062), "2" },
                    { -727713645, "Would not recommend.", 49, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2969), "1" },
                    { -683547773, "", 4, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(454), "2" },
                    { -671231904, "Really enjoyed it.", 42, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2633), "3" },
                    { -626093365, "Not bad, but could be better.", 36, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2279), "3" },
                    { -550528544, "Really enjoyed it.", 30, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1949), "1" },
                    { -498021567, "A masterpiece!", 7, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(676), "1" },
                    { -472328871, "", 48, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2899), "3" },
                    { -461243488, "A masterpiece!", 28, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1874), "2" },
                    { -453211799, "Would not recommend.", 39, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2400), "2" },
                    { -439472186, "Great movie!", 22, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1584), "3" },
                    { -423744754, "Really enjoyed it.", 37, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2327), "1" },
                    { -307066675, "Would not recommend.", 41, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2496), "2" },
                    { -253558129, "Great movie!", 18, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1390), "2" },
                    { -201965260, "", 10, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(867), "3" },
                    { -194657207, "Not bad, but could be better.", 44, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2732), "3" },
                    { -181826915, "Would not recommend.", 40, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2472), "1" },
                    { -112317479, "", 27, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1826), "1" },
                    { -94592764, "Really enjoyed it.", 47, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2875), "3" },
                    { -64590786, "Not bad, but could be better.", 34, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2160), "2" },
                    { -63262785, "", 1, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(268), "3" },
                    { -6640397, "Really enjoyed it.", 48, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2922), "2" },
                    { 6368059, "Great movie!", 47, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2852), "3" },
                    { 8230794, "Not bad, but could be better.", 46, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2826), "3" },
                    { 105523851, "Great movie!", 45, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2779), "3" },
                    { 164476665, "Not bad, but could be better.", 26, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1754), "1" },
                    { 193170724, "Great movie!", 38, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2374), "1" },
                    { 218561123, "Great movie!", 16, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1264), "2" },
                    { 269443040, "Not bad, but could be better.", 36, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2256), "2" },
                    { 319015261, "", 38, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2350), "2" },
                    { 330151347, "Not bad, but could be better.", 50, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(3017), "1" },
                    { 414830437, "Would not recommend.", 17, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1340), "3" },
                    { 469691313, "Not bad, but could be better.", 12, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(963), "1" },
                    { 514254592, "Not bad, but could be better.", 21, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1513), "1" },
                    { 566202988, "Not bad, but could be better.", 19, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1418), "3" },
                    { 689116190, "Would not recommend.", 10, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(890), "1" },
                    { 695570157, "Really enjoyed it.", 50, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2993), "2" },
                    { 743525963, "Would not recommend.", 32, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2062), "2" },
                    { 786665187, "A masterpiece!", 25, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1706), "1" },
                    { 799760484, "A masterpiece!", 43, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2660), "3" },
                    { 829379965, "Not bad, but could be better.", 49, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2946), "1" },
                    { 841961860, "Not bad, but could be better.", 31, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2038), "2" },
                    { 866274981, "A masterpiece!", 6, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(618), "2" },
                    { 958102546, "Would not recommend.", 35, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2209), "3" },
                    { 970266962, "A masterpiece!", 45, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2756), "2" },
                    { 1000728698, "", 2, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(309), "1" },
                    { 1042064542, "Really enjoyed it.", 3, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(419), "3" },
                    { 1042980575, "", 8, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(761), "3" },
                    { 1086121076, "", 31, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2014), "2" },
                    { 1180345652, "", 2, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(345), "3" },
                    { 1194611681, "Great movie!", 30, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1973), "1" },
                    { 1216197910, "Really enjoyed it.", 44, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2708), "3" },
                    { 1251042358, "", 9, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(816), "3" },
                    { 1274251667, "A masterpiece!", 40, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2448), "3" },
                    { 1291733136, "Not bad, but could be better.", 29, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1921), "1" },
                    { 1293131027, "Great movie!", 26, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1777), "3" },
                    { 1298511331, "A masterpiece!", 11, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(916), "1" },
                    { 1362200786, "Great movie!", 32, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2086), "2" },
                    { 1494014245, "Really enjoyed it.", 25, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1729), "3" },
                    { 1552119319, "Would not recommend.", 3, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(382), "2" },
                    { 1684033805, "A masterpiece!", 27, 3, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1803), "1" },
                    { 1686332801, "", 13, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1038), "2" },
                    { 1690926553, "Not bad, but could be better.", 28, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1850), "2" },
                    { 1728104605, "", 19, 4, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1442), "2" },
                    { 1792362025, "Not bad, but could be better.", 43, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2684), "1" },
                    { 1793127234, "Not bad, but could be better.", 7, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(732), "2" },
                    { 1900278091, "Would not recommend.", 20, 2, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1466), "3" },
                    { 1910753633, "Not bad, but could be better.", 34, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(2183), "3" },
                    { 1945012091, "", 20, 1, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1489), "3" },
                    { 2021478111, "Really enjoyed it.", 29, 5, new DateTime(2024, 9, 9, 0, 9, 1, 41, DateTimeKind.Local).AddTicks(1898), "1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -2114253428);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -2098329563);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -2020048327);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1998371247);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1949664316);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1901508636);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1897899896);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1845699736);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1805598415);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1717745230);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1606702394);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1569710433);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1503281918);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1419506644);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1409578747);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1381376148);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1378549022);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1350271445);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1315666479);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1257468117);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1172892621);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1109671825);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1084293906);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -1078423083);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -985339848);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -977117385);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -896715856);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -885465714);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -884179571);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -880967854);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -755467274);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -727713645);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -683547773);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -671231904);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -626093365);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -550528544);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -498021567);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -472328871);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -461243488);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -453211799);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -439472186);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -423744754);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -307066675);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -253558129);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -201965260);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -194657207);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -181826915);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -112317479);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -94592764);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -64590786);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -63262785);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: -6640397);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6368059);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8230794);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 105523851);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 164476665);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 193170724);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 218561123);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 269443040);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 319015261);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 330151347);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 414830437);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 469691313);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 514254592);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 566202988);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 689116190);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 695570157);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 743525963);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 786665187);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 799760484);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 829379965);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 841961860);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 866274981);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 958102546);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 970266962);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1000728698);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1042064542);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1042980575);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1086121076);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1180345652);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1194611681);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1216197910);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1251042358);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1274251667);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1291733136);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1293131027);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1298511331);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1362200786);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1494014245);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1552119319);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1684033805);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1686332801);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1690926553);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1728104605);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1792362025);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1793127234);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1900278091);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1910753633);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1945012091);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2021478111);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
