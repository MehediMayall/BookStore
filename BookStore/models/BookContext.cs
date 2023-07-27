using Microsoft.EntityFrameworkCore;

namespace BookStore.models;

public class BookContext: DbContext
{

    private const string ConnectionString = "server=.;database=bookstore;user id = sa;password=e0LZ0G*#%B9)G9}P95;Trusted_Connection=false;TrustServerCertificate=true";

    // public BookContext(DbContextOptions options): base(options)
    // {
    //     // options.UseSqlServer(ConnectionString);
    // }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString: ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Book>().HasOne(e=> e.Author).WithMany(e=> e.Books).HasForeignKey(e=> e.AuthorID).IsRequired();
    }
    


}