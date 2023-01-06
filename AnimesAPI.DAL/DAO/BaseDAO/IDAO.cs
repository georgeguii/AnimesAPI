namespace AnimesAPI.DAL.DAO.BaseDAO
{
    public interface IDAO<T> where T : class
    {
        T Create(T obj);
        IEnumerable<T> Get();
        T GetOne(long id);
        T GetOne(string valor);
        T Update(T obj);
        void Delete(T obj, bool save = true);
        void Delete(long id, bool save = true);
        void Delete(string valor, bool save = true);

    }
}
