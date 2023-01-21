using AnimesAPI.DAL.Entities;

namespace AnimesAPI.Repository.Interfaces
{
    public interface IAnimeGenreRepository
    {
        AnimeGenre Create(AnimeGenre createAnimeGenre);

        Task<List<AnimeGenre>> GetAll();
    }
}
