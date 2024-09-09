using AutoMapper;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Models;

namespace MovieCatalogMVC.Extensions;

public static class PagedListExtensions
{
    public static PagedResult<MovieModel> MapToPagedResultMovieModel(this PagedResult<Movie> pagedResultMovie, IMapper mapper)
    {
        var pagedResultMovieModel = new PagedResult<MovieModel>
        {
            CurrentPage = pagedResultMovie.CurrentPage,
            PageCount = pagedResultMovie.PageCount,
            PageSize = pagedResultMovie.PageSize,
            RowCount = pagedResultMovie.RowCount,
        };

        foreach (var item in pagedResultMovie.Results)
        {
            var model = mapper.Map<MovieModel>(item);
            pagedResultMovieModel.Results.Add(model);
        }

        return pagedResultMovieModel;
    }

    public static PagedResult<ReviewModel> MapToPagedResultReviewModel(this PagedResult<Review> pagedResultReview, IMapper mapper)
    {
        var pagedResultReviewModel = new PagedResult<ReviewModel>
        {
            CurrentPage = pagedResultReview.CurrentPage,
            PageCount = pagedResultReview.PageCount,
            PageSize = pagedResultReview.PageSize,
            RowCount = pagedResultReview.RowCount,
        };

        foreach(var item in pagedResultReview.Results)
        {
            var model = mapper.Map<ReviewModel>(item);
            pagedResultReviewModel.Results.Add(model);
        }

        return pagedResultReviewModel;
    }
}
