using Microsoft.EntityFrameworkCore;

namespace MovieCatalogMVC.Common.PagedList;

public static class Pagination
{
    public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int page, int pageSize = 10) where T : class
    {
        var result = new PagedResult<T>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = await query.CountAsync();

        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount);

        var skip = (page - 1) * pageSize;
        result.Results = await query
            .Skip(skip)
            .Take(pageSize)
            .ToListAsync();

        return result;
    }
}
