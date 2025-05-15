using Microsoft.EntityFrameworkCore;

public interface IRepository<T>
{
    T? GetById(int id);
    List<T> GetAll();
    T Add(T entity);
    void Update(T entity);
    string? Delete(int id);
}

public class Repository<T>: IRepository<T> where T: class
{
    private readonly DbContext Context;
    private readonly DbSet<T> DbSet;
    public Repository (DbContext context)
    {
        Context = context;
        DbSet = context.Set<T>();
    }

    public T? GetById(int id)
    {
        return DbSet.Find(id); 
    }

    public List<T> GetAll()
    {
        return DbSet.ToList<T>();
    }

    public T Add(T entity)
    {
        DbSet.Add(entity);
        return entity;
    }

    public void Update(T entity)
    {
        Context.Entry(entity).CurrentValues.SetValues(entity);
    }

    public string? Delete(int id)
    {
        var found = DbSet.Find(id);
        if (found == null)
        {   
            return null;
        }
        DbSet.Remove(found);
        return $"Exercise with id: {id} deleted successfully!";
    }

}