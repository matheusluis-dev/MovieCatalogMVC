using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieCatalogMVC.Entities;

namespace MovieCatalogMVC.Data
{
    public class MovieCatalogMVCContext : IdentityDbContext
    {
        public MovieCatalogMVCContext(DbContextOptions<MovieCatalogMVCContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Streaming> Streamings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MoviesStreamings> MoviesStreamings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .Ignore(user => user.ConcurrencyStamp)
                .Ignore(user => user.LockoutEnabled)
                .Ignore(user => user.LockoutEnd);

            modelBuilder.Entity<MoviesStreamings>()
                .HasKey(ms => new { ms.MovieId, ms.StreamingId });

            modelBuilder.Entity<MoviesStreamings>()
                .HasOne(ms => ms.Movie)
                .WithMany(m => m.MoviesStreamings)
                .HasForeignKey(ms => ms.MovieId);

            modelBuilder.Entity<MoviesStreamings>()
                .HasOne(ms => ms.Streaming)
                .WithMany(s => s.MoviesStreamings)
                .HasForeignKey(ms => ms.StreamingId);

            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1", // Primary key
                    UserName = "user1@example.com",
                    NormalizedUserName = "USER1@EXAMPLE.COM",
                    Email = "user1@example.com",
                    NormalizedEmail = "USER1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password123!"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new IdentityUser
                {
                    Id = "2", // Primary key
                    UserName = "user2@example.com",
                    NormalizedUserName = "USER2@EXAMPLE.COM",
                    Email = "user2@example.com",
                    NormalizedEmail = "USER2@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password123!"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new IdentityUser
                {
                    Id = "3", // Primary key
                    UserName = "user3@example.com",
                    NormalizedUserName = "USER3@EXAMPLE.COM",
                    Email = "user3@example.com",
                    NormalizedEmail = "USER3@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password123!"),
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Action" },
                new Genre { GenreId = 2, Name = "Comedy" },
                new Genre { GenreId = 3, Name = "Drama" },
                new Genre { GenreId = 4, Name = "Fantasy" },
                new Genre { GenreId = 5, Name = "Horror" },
                new Genre { GenreId = 6, Name = "Mystery" },
                new Genre { GenreId = 7, Name = "Romance" },
                new Genre { GenreId = 8, Name = "Thriller" },
                new Genre { GenreId = 9, Name = "Western" },
                new Genre { GenreId = 10, Name = "Documentary" },
                new Genre { GenreId = 11, Name = "Animation" },
                new Genre { GenreId = 12, Name = "Sci-Fi" },
                new Genre { GenreId = 13, Name = "Adventure" },
                new Genre { GenreId = 14, Name = "Crime" },
                new Genre { GenreId = 15, Name = "Musical" }
            );

            modelBuilder.Entity<Streaming>().HasData(
                new Streaming { StreamingId = 1, Name = "Netflix" },
                new Streaming { StreamingId = 2, Name = "Amazon Prime Video" },
                new Streaming { StreamingId = 3, Name = "Disney+" },
                new Streaming { StreamingId = 4, Name = "HBO Max" },
                new Streaming { StreamingId = 5, Name = "Hulu" }
            );

            modelBuilder.Entity<Movie>().HasData(
                // Action
                new Movie { MovieId = 1, Title = "Mad Max: Fury Road", ReleaseDate = new DateTime(2015, 5, 1), GenreId = 1 },
                new Movie { MovieId = 2, Title = "John Wick", ReleaseDate = new DateTime(2014, 10, 1), GenreId = 1 },
                new Movie { MovieId = 3, Title = "Die Hard", ReleaseDate = new DateTime(1988, 7, 1), GenreId = 1 },
                new Movie { MovieId = 4, Title = "The Dark Knight", ReleaseDate = new DateTime(2008, 7, 1), GenreId = 1 },

                // Comedy
                new Movie { MovieId = 5, Title = "Superbad", ReleaseDate = new DateTime(2007, 8, 1), GenreId = 2 },
                new Movie { MovieId = 6, Title = "The Grand Budapest Hotel", ReleaseDate = new DateTime(2014, 3, 1), GenreId = 2 },
                new Movie { MovieId = 7, Title = "Step Brothers", ReleaseDate = new DateTime(2008, 7, 1), GenreId = 2 },
                new Movie { MovieId = 8, Title = "Anchorman: The Legend of Ron Burgundy", ReleaseDate = new DateTime(2004, 7, 1), GenreId = 2 },

                // Drama
                new Movie { MovieId = 9, Title = "The Shawshank Redemption", ReleaseDate = new DateTime(1994, 9, 1), GenreId = 3 },
                new Movie { MovieId = 10, Title = "Forrest Gump", ReleaseDate = new DateTime(1994, 7, 1), GenreId = 3 },
                new Movie { MovieId = 11, Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 1), GenreId = 3 },
                new Movie { MovieId = 12, Title = "A Beautiful Mind", ReleaseDate = new DateTime(2001, 12, 1), GenreId = 3 },

                // Fantasy
                new Movie { MovieId = 13, Title = "The Lord of the Rings: The Fellowship of the Ring", ReleaseDate = new DateTime(2001, 12, 1), GenreId = 4 },
                new Movie { MovieId = 14, Title = "Harry Potter and the Sorcerer's Stone", ReleaseDate = new DateTime(2001, 11, 1), GenreId = 4 },
                new Movie { MovieId = 15, Title = "Pan's Labyrinth", ReleaseDate = new DateTime(2006, 10, 1), GenreId = 4 },
                new Movie { MovieId = 16, Title = "Spirited Away", ReleaseDate = new DateTime(2001, 9, 1), GenreId = 4 },

                // Horror
                new Movie { MovieId = 17, Title = "The Exorcist", ReleaseDate = new DateTime(1973, 12, 1), GenreId = 5 },
                new Movie { MovieId = 18, Title = "Get Out", ReleaseDate = new DateTime(2017, 2, 1), GenreId = 5 },
                new Movie { MovieId = 19, Title = "A Quiet Place", ReleaseDate = new DateTime(2018, 4, 1), GenreId = 5 },
                new Movie { MovieId = 20, Title = "Hereditary", ReleaseDate = new DateTime(2018, 6, 1), GenreId = 5 },

                // Mystery
                new Movie { MovieId = 21, Title = "Knives Out", ReleaseDate = new DateTime(2019, 11, 1), GenreId = 6 },
                new Movie { MovieId = 22, Title = "Se7en", ReleaseDate = new DateTime(1995, 9, 1), GenreId = 6 },
                new Movie { MovieId = 23, Title = "Gone Girl", ReleaseDate = new DateTime(2014, 10, 1), GenreId = 6 },

                // Romance
                new Movie { MovieId = 24, Title = "The Notebook", ReleaseDate = new DateTime(2004, 6, 1), GenreId = 7 },
                new Movie { MovieId = 25, Title = "Pride and Prejudice", ReleaseDate = new DateTime(2005, 11, 1), GenreId = 7 },
                new Movie { MovieId = 26, Title = "La La Land", ReleaseDate = new DateTime(2016, 12, 1), GenreId = 7 },

                // Thriller
                new Movie { MovieId = 27, Title = "The Silence of the Lambs", ReleaseDate = new DateTime(1991, 2, 1), GenreId = 8 },
                new Movie { MovieId = 28, Title = "Fight Club", ReleaseDate = new DateTime(1999, 10, 1), GenreId = 8 },
                new Movie { MovieId = 29, Title = "Prisoners", ReleaseDate = new DateTime(2013, 9, 1), GenreId = 8 },

                // Western
                new Movie { MovieId = 30, Title = "The Good, the Bad and the Ugly", ReleaseDate = new DateTime(1966, 12, 1), GenreId = 9 },
                new Movie { MovieId = 31, Title = "Unforgiven", ReleaseDate = new DateTime(1992, 8, 1), GenreId = 9 },
                new Movie { MovieId = 32, Title = "True Grit", ReleaseDate = new DateTime(2010, 12, 1), GenreId = 9 },

                // Documentary
                new Movie { MovieId = 33, Title = "13th", ReleaseDate = new DateTime(2016, 10, 1), GenreId = 10 },
                new Movie { MovieId = 34, Title = "Free Solo", ReleaseDate = new DateTime(2018, 9, 1), GenreId = 10 },
                new Movie { MovieId = 35, Title = "The Social Dilemma", ReleaseDate = new DateTime(2020, 1, 1), GenreId = 10 },

                // Animation
                new Movie { MovieId = 36, Title = "Toy Story", ReleaseDate = new DateTime(1995, 11, 1), GenreId = 11 },
                new Movie { MovieId = 37, Title = "Finding Nemo", ReleaseDate = new DateTime(2003, 5, 1), GenreId = 11 },
                new Movie { MovieId = 38, Title = "Spirited Away", ReleaseDate = new DateTime(2001, 9, 1), GenreId = 11 },

                // Sci-Fi
                new Movie { MovieId = 39, Title = "Inception", ReleaseDate = new DateTime(2010, 7, 1), GenreId = 12 },
                new Movie { MovieId = 40, Title = "Blade Runner 2049", ReleaseDate = new DateTime(2017, 10, 1), GenreId = 12 },
                new Movie { MovieId = 41, Title = "The Matrix", ReleaseDate = new DateTime(1999, 3, 1), GenreId = 12 },

                // Adventure
                new Movie { MovieId = 42, Title = "Jurassic Park", ReleaseDate = new DateTime(1993, 6, 1), GenreId = 13 },
                new Movie { MovieId = 43, Title = "Indiana Jones: Raiders of the Lost Ark", ReleaseDate = new DateTime(1981, 6, 1), GenreId = 13 },
                new Movie { MovieId = 44, Title = "Jumanji", ReleaseDate = new DateTime(1995, 12, 1), GenreId = 13 },

                // Crime
                new Movie { MovieId = 45, Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 1), GenreId = 14 },
                new Movie { MovieId = 46, Title = "Goodfellas", ReleaseDate = new DateTime(1990, 9, 1), GenreId = 14 },
                new Movie { MovieId = 47, Title = "Pulp Fiction", ReleaseDate = new DateTime(1994, 10, 1), GenreId = 14 },

                // Musical
                new Movie { MovieId = 48, Title = "The Sound of Music", ReleaseDate = new DateTime(1965, 3, 1), GenreId = 15 },
                new Movie { MovieId = 49, Title = "La La Land", ReleaseDate = new DateTime(2016, 12, 1), GenreId = 15 },
                new Movie { MovieId = 50, Title = "Chicago", ReleaseDate = new DateTime(2002, 12, 1), GenreId = 15 }
            );

            modelBuilder.Entity<MoviesStreamings>().HasData(
                // Movie 1 Streamings
                new MoviesStreamings { MovieId = 1, StreamingId = 1 },
                new MoviesStreamings { MovieId = 1, StreamingId = 3 },

                // Movie 2 Streamings
                new MoviesStreamings { MovieId = 2, StreamingId = 2 },
                new MoviesStreamings { MovieId = 2, StreamingId = 4 },

                // Movie 3 Streamings
                new MoviesStreamings { MovieId = 3, StreamingId = 1 },
                new MoviesStreamings { MovieId = 3, StreamingId = 5 },

                // Movie 4 Streamings
                new MoviesStreamings { MovieId = 4, StreamingId = 3 },
                new MoviesStreamings { MovieId = 4, StreamingId = 2 },

                // Movie 5 Streamings
                new MoviesStreamings { MovieId = 5, StreamingId = 4 },

                // Movie 6 Streamings
                new MoviesStreamings { MovieId = 6, StreamingId = 5 },

                // Movie 7 Streamings
                new MoviesStreamings { MovieId = 7, StreamingId = 3 },
                new MoviesStreamings { MovieId = 7, StreamingId = 1 },

                // Movie 8 Streamings
                new MoviesStreamings { MovieId = 8, StreamingId = 2 },

                // Movie 9 Streamings
                new MoviesStreamings { MovieId = 9, StreamingId = 1 },
                new MoviesStreamings { MovieId = 9, StreamingId = 4 },

                // Movie 10 Streamings
                new MoviesStreamings { MovieId = 10, StreamingId = 5 },

                // Continue similar for other movies...
                new MoviesStreamings { MovieId = 11, StreamingId = 2 },
                new MoviesStreamings { MovieId = 12, StreamingId = 3 },
                new MoviesStreamings { MovieId = 13, StreamingId = 4 },
                new MoviesStreamings { MovieId = 14, StreamingId = 5 },
                new MoviesStreamings { MovieId = 15, StreamingId = 1 },
                new MoviesStreamings { MovieId = 16, StreamingId = 2 },
                new MoviesStreamings { MovieId = 17, StreamingId = 3 },
                new MoviesStreamings { MovieId = 18, StreamingId = 4 },
                new MoviesStreamings { MovieId = 19, StreamingId = 5 },
                new MoviesStreamings { MovieId = 20, StreamingId = 1 },
                new MoviesStreamings { MovieId = 21, StreamingId = 2 },
                new MoviesStreamings { MovieId = 22, StreamingId = 3 },
                new MoviesStreamings { MovieId = 23, StreamingId = 4 },
                new MoviesStreamings { MovieId = 24, StreamingId = 5 },
                new MoviesStreamings { MovieId = 25, StreamingId = 1 },
                new MoviesStreamings { MovieId = 26, StreamingId = 2 },
                new MoviesStreamings { MovieId = 27, StreamingId = 3 },
                new MoviesStreamings { MovieId = 28, StreamingId = 4 },
                new MoviesStreamings { MovieId = 29, StreamingId = 5 },
                new MoviesStreamings { MovieId = 30, StreamingId = 1 },
                new MoviesStreamings { MovieId = 31, StreamingId = 2 },
                new MoviesStreamings { MovieId = 32, StreamingId = 3 },
                new MoviesStreamings { MovieId = 33, StreamingId = 4 },
                new MoviesStreamings { MovieId = 34, StreamingId = 5 },
                new MoviesStreamings { MovieId = 35, StreamingId = 1 },
                new MoviesStreamings { MovieId = 36, StreamingId = 2 },
                new MoviesStreamings { MovieId = 37, StreamingId = 3 },
                new MoviesStreamings { MovieId = 38, StreamingId = 4 },
                new MoviesStreamings { MovieId = 39, StreamingId = 5 },
                new MoviesStreamings { MovieId = 40, StreamingId = 1 },
                new MoviesStreamings { MovieId = 41, StreamingId = 2 },
                new MoviesStreamings { MovieId = 42, StreamingId = 3 },
                new MoviesStreamings { MovieId = 43, StreamingId = 4 },
                new MoviesStreamings { MovieId = 44, StreamingId = 4 },
                new MoviesStreamings { MovieId = 45, StreamingId = 2 },
                new MoviesStreamings { MovieId = 46, StreamingId = 3 },
                new MoviesStreamings { MovieId = 47, StreamingId = 1 },
                new MoviesStreamings { MovieId = 48, StreamingId = 2 },
                new MoviesStreamings { MovieId = 49, StreamingId = 3 },
                new MoviesStreamings { MovieId = 50, StreamingId = 5 }
            );

            var random = new Random();
            var comments = new List<string>
            {
                "Great movie!",
                "Really enjoyed it.",
                "Not bad, but could be better.",
                "Would not recommend.",
                "A masterpiece!",
                string.Empty
            };

            var movieIds = Enumerable.Range(1, 50);
            var userIds = new List<string> { "1", "2", "3" };

            foreach (var movieId in movieIds)
            {
                for (int i = 0; i < 2; i++)
                {
                    var review = new Review
                    {
                        ReviewId = Guid.NewGuid().GetHashCode(),
                        Rate = random.Next(1, 6),
                        Comment = comments[random.Next(comments.Count)],
                        ReviewDate = DateTime.Now,
                        MovieId = movieId,
                        UserId = userIds.ElementAt(random.Next(userIds.Count()))
                    };
                    modelBuilder.Entity<Review>().HasData(review);
                }
            }
        }
    }
}
