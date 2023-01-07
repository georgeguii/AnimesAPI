using AnimesAPI.DAL.Entities;
using AnimesAPI.Repository.Interfaces;
using AnimesAPI.DAL.DAO.BaseDAO;

namespace AnimesAPI.Repository
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly IDAO<Anime> _animeDAO;

        public AnimeRepository(IDAO<Anime> animeDAO)
        {
            _animeDAO = animeDAO;
        }

        public Anime CreateAnime(Anime createAnime)
            => _animeDAO.Create(createAnime);

        public async Task<List<Anime>> GetAllAnimes(int page)
            =>(await _animeDAO.Get()).Where(i => i.IsDeleted == false).Skip((page - 1) * 10).Take(10).ToList();

    }
}
