﻿using AutoMapper;
using AnimesAPI.DTO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.Manager.Interfaces;
using AnimesAPI.Repository.Interfaces;

namespace AnimesAPI.Manager
{
    public class AnimeManager : IAnimeManager
    {
        private readonly IMapper _mapper;
        private readonly IGenreRepository _genreRepository;
        private readonly IAnimeRepository _animeRepository;

        public AnimeManager(IMapper mapper, IGenreRepository genreRepository, IAnimeRepository animeRepository)
        {
            _mapper = mapper;
            _animeRepository = animeRepository;
            _genreRepository = genreRepository;
        }

        public AnimeDTO Create(AnimeDTO createAnimeDto)
        {
            //Verificar lista de Id dos Genres
            foreach (var teste in createAnimeDto.Genres)
            {
                var aoba = _genreRepository.GetAsyncById(teste);
                if (aoba == null) throw new NullReferenceException("O gênero informado não existe");
            }
            

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
