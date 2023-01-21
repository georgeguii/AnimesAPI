using AutoMapper;
using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.Manager.Interfaces;
using AnimesAPI.Repository.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace AnimesAPI.Manager
{
    public class AnimeManager : IAnimeManager
    {
        private readonly IMapper _mapper;
        private readonly IAnimeRepository _animeRepository;

        public AnimeManager(IMapper mapper, IAnimeRepository animeRepository)
        {
            _mapper = mapper;
            _animeRepository = animeRepository;
        }

        public async Task<AnimeDTO> Create(AnimeDTO createAnimeDto)
        {
            //Anime toCreateAnime = new Anime()
            //{
            //    Name = createAnimeDto.Name,
            //    Resume = createAnimeDto.Resume,
            //    Status = createAnimeDto.Status,
            //    Studio = createAnimeDto.Studio,
            //    Source = createAnimeDto.Source,
            //    AnimeGenres = createAnimeDto.Genres,
            //    Director = createAnimeDto.Director
            //};

            Anime createAnime = _mapper.Map<Anime>(createAnimeDto);

            Anime createdAnime = await _animeRepository.CreateAnime(createAnime);

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
