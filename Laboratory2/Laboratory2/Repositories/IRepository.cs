namespace Laboratory2.Repositories
{
    public interface IRepository<T>
    {
        void AddOrUpdate(T t);

        void Delete(T t);

        void DeleteById(int id);

        void DeleteAll();
    }
}