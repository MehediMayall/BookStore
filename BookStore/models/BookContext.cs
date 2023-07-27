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
        modelBuilder.Entity<Book>().Property(e=> e.Title).HasMaxLength(150).IsRequired();
        modelBuilder.Entity<Book>().Property(e=> e.Description).HasMaxLength(250);
        modelBuilder.Entity<Book>().Property(e=> e.PublishedOn).IsRequired();
        modelBuilder.Entity<Book>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<Book>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");



        // Author
        modelBuilder.Entity<Author>().HasKey(e=> e.Id);
        modelBuilder.Entity<Author>().Property(e=> e.Firstname).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Author>().Property(e=> e.Lastname).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Author>().HasIndex(e=> e.Email).IsUnique();
        modelBuilder.Entity<Author>().HasIndex(e=> e.Mobile).IsUnique();
        modelBuilder.Entity<Author>().Property(e=> e.Email).HasMaxLength(100);
        modelBuilder.Entity<Author>().Property(e=> e.Mobile).HasMaxLength(100);
        modelBuilder.Entity<Author>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<Author>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");


        // Book Author
        modelBuilder.Entity<BookAuthor>().HasKey(e=> new { e.BookID, e.AuthorID});

        // Tag
        modelBuilder.Entity<Tag>().HasKey(e=> e.Id);

        // Book Tags
        modelBuilder.Entity<BookTags>().HasKey(e=> new {e.BookID, e.TagID});
    }
}