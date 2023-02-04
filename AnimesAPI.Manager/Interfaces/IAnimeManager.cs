using AnimesAPI.DTO;

namespace AnimesAPI.Manager.Interfaces
{
    public interface IAnimeManager
    {
        Task<AnimeDTO> Create(AnimeDTO createAnimeDto);

        Task<List<AnimeDTO>> GetAllAsync(int page);
    }
}
