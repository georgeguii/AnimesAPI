using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;

namespace AnimesAPI.Repository.Interfaces
{
    public interface IAnimeRepository
    {
        Anime CreateAnime(Anime createAnime);

        Task<List<Anime>> GetAllAnimes(int page);

        //Anime GetAnimeById(int animeId);

        //List<Anime> GetAnimeBySource(int source, int page);

        //List<Anime> GetAnimesByDirector(string director, int page);

        //List<Anime> GetAnimeByStudio(string studio, int page);

        //List<Anime> GetAnimeByStatus(int statusEnum, int page);

        //Anime UpdateAnime(Anime updateAnime);

        //Anime SoftDeleteAnime(int id);

    }
}
