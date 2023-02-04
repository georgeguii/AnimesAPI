using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.DAO.BaseDAO;


namespace AnimesAPI.DAL.DAO
{
    public class AnimeDAO : BaseDAO<Anime>
    {
        public AnimeDAO(AnimesDbContext context) : base(context)
        {

        }
    }
}
