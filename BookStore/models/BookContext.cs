namespace bookstore.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class BookContext : DbContext
{
    
    private readonly string ConnectionString = "Server=.;Database=bookstore;User=sa;Password=e0LZ0G*#%B9)G9}P95;Trusted_Connection=false;TrustServerCertificate=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    // Models
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors{ get; set; }
    public DbSet<Tag> Tags { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Book
        modelBuilder.Entity<Book>().HasKey(e=> e.Id);

        // Author
        modelBuilder.Entity<Author>().HasKey(e=> e.Id);

        // Tag
        modelBuilder.Entity<Tag>().HasKey(e=> e.Id);
    }
}