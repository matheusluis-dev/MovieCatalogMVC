using Microsoft.AspNetCore.Identity;

namespace MovieCatalogMVC.Entities;

public class Review
{
    public int ReviewId { get; set; }
    public int Rate { get; set; }
    public string Comment { get; set; }
    public DateTime? ReviewDate { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
