using AnimesAPI.DAL.DAO.BaseDAO;
using AnimesAPI.DAL.Entities;


namespace AnimesAPI.DAL.DAO
{
    public class AnimeDAO : BaseDAO<Anime>
    {
        public AnimeDAO(AnimesDbContext context) : base(context)
        {

        }
    }
}
