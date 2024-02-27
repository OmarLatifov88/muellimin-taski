using task.Models;

namespace task.Contexts;

public class PronioDbContext : DbContext
{
    public PronioDbContext(DbContextOptions<PronioDbContext> options) : base(options)
    {

    }

    public DbSet<Slider> Sliders { get; set; } = null!;
}

public class DbContextOptions<T>
{
}

public class DbContext
{
    public DbContext(DbContextOptions<PronioDbContext> options)
    {
    }
}