namespace MovieCatalogMVC.Entities;

public class Streaming
{
    public int StreamingId { get; set; }
    public string Name { get; set; }

    public ICollection<MoviesStreamings> MoviesStreamings { get; set; }
}
