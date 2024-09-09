using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Data;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Models;
using MovieCatalogMVC.Validators;

namespace MovieCatalogMVC.Extensions;

public static class ServiceExtensions
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext(configuration);
        services.AddControllersWithViews();
        services.AddAutoMapper();
        services.AddFluentValidation();
    }

    private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        services.AddDbContext<MovieCatalogMVCContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<MovieCatalogMVCContext>();
    }

    private static void AddAutoMapper(this IServiceCollection services)
    {
        var config = new MapperConfiguration(configuration =>
        {
            configuration.CreateMap<Genre, GenreModel>().ReverseMap();
            configuration.CreateMap<PagedResult<Genre>, PagedResult<GenreModel>>().ReverseMap();

            configuration.CreateMap<Streaming, StreamingModel>().ReverseMap();
            configuration.CreateMap<PagedResult<Streaming>, PagedResult<StreamingModel>>().ReverseMap();

            configuration.CreateMap<Movie, MovieModel>()
                .ForMember(model => model.GenreId, option => option.MapFrom(entity => entity.Genre.GenreId))
                .ForMember(model => model.GenreName, option => option.MapFrom(entity => entity.Genre.Name))
                .ForMember(model =>
                    model.Streamings,
                    option => option.MapFrom(entity => entity.MoviesStreamings.Select(ms => ms.Streaming)))
                .ForMember(model =>
                    model.SelectedStreamingIds,
                    option => option.MapFrom(entity => entity.MoviesStreamings.Select(ms => ms.StreamingId)))
                .ReverseMap();

            configuration.CreateMap<Review, ReviewModel>()
                .ForMember(model => model.MovieId, option => option.MapFrom(entity => entity.Movie.MovieId))
                .ForMember(model => model.MovieTitle, option => option.MapFrom(entity => entity.Movie.Title))
                .ForMember(model => model.UserId, option => option.MapFrom(entity => entity.User.Id))
                .ForMember(model => model.UserName, option => option.MapFrom(entity => entity.User.UserName))
                .ReverseMap();
        });

        var mapper = config.CreateMapper();

        services.AddSingleton(mapper);
    }

    private static void AddFluentValidation(this IServiceCollection services)
    {
        services.AddScoped<IValidator<Genre>, GenreValidator>();
        services.AddScoped<IValidator<Streaming>, StreamingValidator>();
        services.AddScoped<IValidator<MovieModel>, MovieValidator>();
        services.AddScoped<IValidator<ReviewModel>, ReviewValidator>();
    }
}
