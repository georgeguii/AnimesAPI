using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.DAO.BaseDAO;
using AnimesAPI.Repository.Interfaces;

namespace AnimesAPI.Repository
{
    public class AnimeGenreRepository : IAnimeGenreRepository
    {

        private readonly IDAO<AnimeGenre> _animeGenreDAO;

        public AnimeGenreRepository(IDAO<AnimeGenre> animeGenreDAO)
        {
            _animeGenreDAO = animeGenreDAO;
        }


        public AnimeGenre Create(AnimeGenre createAnimeGenre)
            => _animeGenreDAO.Create(createAnimeGenre);

        public async Task<List<AnimeGenre>> GetAll()
            => (await _animeGenreDAO.Get()).ToList();
    }
}
