using AnimesAPI.DAL.Entities;
using AnimesAPI.DAL.DAO.BaseDAO;

namespace AnimesAPI.DAL.DAO
{
    public class GenreDAO : BaseDAO<Genre>
    {
        public GenreDAO(AnimesDbContext context) : base(context)
        {

        }
    }
}
