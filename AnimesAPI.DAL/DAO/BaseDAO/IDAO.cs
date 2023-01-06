namespace AnimesAPI.DAL.DAO.BaseDAO
{
    public interface IDAO<T> where T : class
    {
        T Create(T obj);
        Task<IEnumerable<T>> Get();
        Task<T> GetOne(long id);
        Task<T> GetOne(string valor);
        T Update(T obj);
        void Delete(T obj, bool save = true);
        void Delete(long id, bool save = true);
        void Delete(string valor, bool save = true);

    }
}
