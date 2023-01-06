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

        public AnimeDTO CreateAnime(AnimeDTO createAnimeDto)
        {
            Anime newAnime = _mapper.Map<Anime>(createAnimeDto);

            Anime createdAnime = _animeDAO.Create(newAnime);

            AnimeDTO createdAnimeDtoResponse = _mapper.Map<AnimeDTO>(createdAnime);

            return createdAnimeDtoResponse;
        }
    }
}
