using AnimesAPI.DAL.DAO.BaseDAO;
using AnimesAPI.DAL.Entities;
using AnimesAPI.Repository.Interfaces;
using System.IO;

namespace AnimesAPI.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IDAO<Genre> _genreDAO;

        public GenreRepository(IDAO<Genre> genreDAO)
        {
            _genreDAO = genreDAO;
        }

        public async Task<List<Genre>> GetAllAsync(int page)
            => (await _genreDAO.Get()).Skip((page - 1) * 10).Take(10).ToList();


        public async Task<Genre> GetAsyncById(int genreId)
            => await _genreDAO.GetOne(genreId);

    }
}
