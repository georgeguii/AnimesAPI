using AutoMapper;
using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.Manager.Interfaces;
using AnimesAPI.Repository.Interfaces;

namespace AnimesAPI.Manager
{
    public class AnimeManager : IAnimeManager
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IMapper _mapper;

        public AnimeManager(IAnimeRepository animeRepository, IMapper mapper)
        {
            _animeRepository = animeRepository;
            _mapper = mapper;
        }

        public AnimeDTO Create(AnimeDTO createAnimeDto)
        {
            //Verificar lista de Id dos Genres

            Anime createAnime = _mapper.Map<Anime>(createAnimeDto);

            Anime createdAnime = _animeRepository.CreateAnime(createAnime);

            AnimeDTO createdAnimeDto = _mapper.Map<AnimeDTO>(createdAnime);

            return createdAnimeDto;
        }

        public async Task<List<AnimeDTO>> GetAllAsync(int page)
        {
            List<Anime> listResponse = await _animeRepository.GetAllAnimes(page);

            List<AnimeDTO> listResponseDto = _mapper.Map<List<AnimeDTO>>(listResponse);

            return listResponseDto;
        }
    }
}
