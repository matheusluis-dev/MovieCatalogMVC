namespace MovieCatalogMVC.Common.PagedList;

public interface IPagedResult<T>
{
    public int CurrentPage { get; set; }
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int RowCount { get; set; }
    public int FirstRowOnPage { get; }
    public int LastRowOnPage{ get; }
    public IList<T> Results { get; set; }
}