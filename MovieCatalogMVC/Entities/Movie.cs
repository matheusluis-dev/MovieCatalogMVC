namespace MovieCatalogMVC.Entities;

public class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public DateTime? ReleaseDate { get; set; }

    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    public ICollection<Review> Reviews { get; set; }
    public ICollection<MoviesStreamings> MoviesStreamings { get; set; }
}
