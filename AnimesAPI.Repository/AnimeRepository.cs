using AnimesAPI.DAL.Entities;
using AnimesAPI.Repository.Interfaces;
using AnimesAPI.DAL.DAO.BaseDAO;

namespace AnimesAPI.Repository
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly IDAO<Anime> _animeDAO;
        private readonly IDAO<Genre> _genreDAO;
        private readonly IDAO<AnimeGenre> _animeGenreDAO;

        public AnimeRepository(IDAO<Anime> animeDAO, IDAO<Genre> genreDAO, IDAO<AnimeGenre> animeGenreDAO)
        {
            _animeDAO = animeDAO;
            _genreDAO = genreDAO;
            _animeGenreDAO = animeGenreDAO;
        }

        public async Task<Anime> CreateAnime(Anime createAnime)
        {
            Anime createdAnime = _animeDAO.Create(createAnime);

            foreach (AnimeGenre uniqueAnimeGenre in createAnime.AnimeGenres)
            {
                Genre genreExist = await _genreDAO.GetOne(uniqueAnimeGenre.GenreId);

                if (genreExist == null) throw new NullReferenceException($"Não existe genêro cadastrado com o id {genreExist.Id}");

                var createdAnimeGenre = 
                    (await _animeGenreDAO.Get())
                    .FirstOrDefault(ag => ag.AnimeId.Equals(createdAnime.Id) && ag.GenreId.Equals(genreExist.Id));

                if (createdAnimeGenre is null)
                {
                    AnimeGenre documentMarker = new AnimeGenre()
                    {
                        AnimeId = createdAnime.Id,
                        GenreId = genreExist.Id
                    };

                    _animeGenreDAO.Create(documentMarker);
                }
            }

            return createdAnime;
        } 

        public async Task<List<Anime>> GetAllAnimes(int page)
            =>(await _animeDAO.Get()).Where(i => i.IsDeleted == false).Skip((page - 1) * 10).Take(10).ToList();

    }
}
