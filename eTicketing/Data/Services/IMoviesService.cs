using eTicketing.Data.Base;
using eTicketing.Models;
using eTicketing.Models.ViewModels;

namespace eTicketing.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(CreateMovieVM data);
        Task UpdateMovieAsync(CreateMovieVM data);
    }
}
