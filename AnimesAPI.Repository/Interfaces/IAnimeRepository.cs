using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;

namespace AnimesAPI.Repository.Interfaces
{
    public interface IAnimeRepository
    {
        AnimeDTO CreateAnime(AnimeDTO createAnimeDto);

        List<AnimeDTO> GetAllAnimes(int page);

        AnimeDTO GetAnimeById(int animeId);

        List<AnimeDTO> GetAnimeBySource(int source, int page);

        List<AnimeDTO> GetAnimesByDirector(string director, int page);

        List<AnimeDTO> GetAnimeByStudio(string studio, int page);

        List<AnimeDTO> GetAnimeByStatus(int statusEnum, int page);

        AnimeDTO UpdateAnime(AnimeDTO updateAnimeDto);

        AnimeDTO SoftDeleteAnime(int id);

    }
}
