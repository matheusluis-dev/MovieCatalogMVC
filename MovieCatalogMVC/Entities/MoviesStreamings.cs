namespace MovieCatalogMVC.Entities;

public class MoviesStreamings
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int StreamingId { get; set; }
    public Streaming Streaming { get; set; }
}
