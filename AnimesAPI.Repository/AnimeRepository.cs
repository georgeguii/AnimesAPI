using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.Repository.Interfaces;
using AutoMapper;
using AnimesAPI.DAL.DAO.BaseDAO;

namespace AnimesAPI.Repository
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly IDAO<Anime> _animeDAO;
        private readonly IMapper _mapper;

        public AnimeRepository(IDAO<Anime> animeDAO, IMapper mapper)
        {
            _animeDAO = animeDAO;
            _mapper = mapper;
        }

        public Anime CreateAnime(Anime createAnime)
            => _animeDAO.Create(createAnime);

        public async Task<List<Anime>> GetAllAnimes(int page)
        {
            List<Anime> animesResponse = new List<Anime>();
            return (await _animeDAO.Get()).Where(i => i.IsDeleted == false).Skip((page - 1) * 10).Take(10).ToList();
        }
    }
}
