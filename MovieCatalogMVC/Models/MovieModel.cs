namespace MovieCatalogMVC.Models;

public class MovieModel
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public DateTime? ReleaseDate { get; set; }

    public int GenreId { get; set; }
    public string GenreName { get; set; }

    public ICollection<ReviewModel> Reviews { get; set; }

    public List<int> SelectedStreamingIds { get; set; }
    public ICollection<StreamingModel> Streamings { get; set; }
}
