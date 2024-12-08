namespace Sticky_Notes.DataBase.Repository;

public interface IGenericRepository<T>
{
    T Get(string id);

    IEnumerable<T> GetAll();

    bool Add(T entity);

    bool Update(T entity);

    bool Delete(T entity);
}