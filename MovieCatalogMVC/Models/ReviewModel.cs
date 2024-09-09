namespace MovieCatalogMVC.Models;

public class ReviewModel
{
    public int ReviewId { get; set; }
    public int? Rate { get; set; }
    public string Comment { get; set; }
    public DateTime? ReviewDate { get; set; }

    public int MovieId { get; set; }
    public string MovieTitle { get; set; }

    public string UserId { get; set; }
    public string UserName { get; set; }
}
