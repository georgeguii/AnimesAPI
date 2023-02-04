using AnimesAPI.DAL.Entities;

namespace AnimesAPI.Repository.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetAllAsync(int page);

        Task<Genre> GetAsyncById(int genreId);
    }
}
