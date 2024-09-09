using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalogMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Movies",
                columns: new[] { "MovieId", "GenreId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max: Fury Road" },
                    { 2, 1, new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Wick" },
                    { 3, 1, new DateTime(1988, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Die Hard" },
                    { 4, 1, new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 5, 2, new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superbad" },
                    { 6, 2, new DateTime(2014, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Grand Budapest Hotel" },
                    { 7, 2, new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Step Brothers" },
                    { 8, 2, new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anchorman: The Legend of Ron Burgundy" },
                    { 9, 3, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 10, 3, new DateTime(1994, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { 11, 3, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 12, 3, new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Beautiful Mind" },
                    { 13, 4, new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring" },
                    { 14, 4, new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Sorcerer's Stone" },
                    { 15, 4, new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pan's Labyrinth" },
                    { 16, 4, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { 17, 5, new DateTime(1973, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Exorcist" },
                    { 18, 5, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get Out" },
                    { 19, 5, new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Quiet Place" },
                    { 20, 5, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hereditary" },
                    { 21, 6, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knives Out" },
                    { 22, 6, new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se7en" },
                    { 23, 6, new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gone Girl" },
                    { 24, 7, new DateTime(2004, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Notebook" },
                    { 25, 7, new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride and Prejudice" },
                    { 26, 7, new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La La Land" },
                    { 27, 8, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silence of the Lambs" },
                    { 28, 8, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { 29, 8, new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prisoners" },
                    { 30, 9, new DateTime(1966, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly" },
                    { 31, 9, new DateTime(1992, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unforgiven" },
                    { 32, 9, new DateTime(2010, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "True Grit" },
                    { 33, 10, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13th" },
                    { 34, 10, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Solo" },
                    { 35, 10, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Social Dilemma" },
                    { 36, 11, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toy Story" },
                    { 37, 11, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finding Nemo" },
                    { 38, 11, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { 39, 12, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 40, 12, new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blade Runner 2049" },
                    { 41, 12, new DateTime(1999, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 42, 13, new DateTime(1993, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park" },
                    { 43, 13, new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana Jones: Raiders of the Lost Ark" },
                    { 44, 13, new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumanji" },
                    { 45, 14, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 46, 14, new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goodfellas" },
                    { 47, 14, new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 48, 15, new DateTime(1965, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sound of Music" },
                    { 49, 15, new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La La Land" },
                    { 50, 15, new DateTime(2002, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago" }
                });

            migrationBuilder.InsertData(
                table: "MoviesStreamings",
                columns: new[] { "MovieId", "StreamingId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 3 },
                    { 8, 2 },
                    { 9, 1 },
                    { 9, 4 },
                    { 10, 5 },
                    { 11, 2 },
                    { 12, 3 },
                    { 13, 4 },
                    { 14, 5 },
                    { 15, 1 },
                    { 16, 2 },
                    { 17, 3 },
                    { 18, 4 },
                    { 19, 5 },
                    { 20, 1 },
                    { 21, 2 },
                    { 22, 3 },
                    { 23, 4 },
                    { 24, 5 },
                    { 25, 1 },
                    { 26, 2 },
                    { 27, 3 },
                    { 28, 4 },
                    { 29, 5 },
                    { 30, 1 },
                    { 31, 2 },
                    { 32, 3 },
                    { 33, 4 },
                    { 34, 5 },
                    { 35, 1 },
                    { 36, 2 },
                    { 37, 3 },
                    { 38, 4 },
                    { 39, 5 },
                    { 40, 1 },
                    { 41, 2 },
                    { 42, 3 },
                    { 43, 4 },
                    { 44, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "MoviesStreamings",
                keyColumns: new[] { "MovieId", "StreamingId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 44);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f85ae5bb-0e29-4839-8c93-09399451f85f", "AQAAAAIAAYagAAAAECWtejQgdLqN+G2DaBrcO9+dvmTDuvrYGFz4QV9IOnwjZP0F4rCQB31r8XXR9RSr/g==", "7a6bdd33-21f0-401f-992e-1cef8a7f23dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e54edbf-cbca-4f68-96b9-7d7e8b0eae02", "AQAAAAIAAYagAAAAEF9urVKA74L0K6H2pjQM2+3F/NzG7EfxyVghlENIAYaRTKrBSBhL2uRzOG+hHk8kxg==", "b2cc5580-b611-4772-9d99-325c9d5a1b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26a1372-0291-40e7-8409-edd5f02f3ca8", "AQAAAAIAAYagAAAAEJRs/A6vw/+SJ8TxM8V4M28stiLZcw7Uw0KCwrAr2xSHDRhpmjX1UqMClI0xMg8n4Q==", "eeef68be-886b-47f6-b96b-596b531dec3c" });
        }
    }
}
