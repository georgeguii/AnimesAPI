using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.DAO.BaseDAO;


namespace AnimesAPI.DAL.DAO
{
    public class AnimeGenreDAO : BaseDAO<AnimeGenre>
    {
        public AnimeGenreDAO(AnimesDbContext context) : base(context)
        {

        }
    }
}