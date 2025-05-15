using Microsoft.EntityFrameworkCore;

public class DbContext<T>: DbContext where T: class
{
    public DbSet<T> exercises {get; set;}
    public DbContext(DbContextOptions options): base(options)
    {}
}