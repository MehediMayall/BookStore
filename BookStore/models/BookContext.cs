namespace bookstore.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class BookContext : DbContext
{
    // private readonly string ConnectionString = "Server=.;Database=bookstore;User=sa;Password=e0LZ0G*#%B9)G9}P95;Trusted_Connection=false;TrustServerCertificate=true;";

    public BookContext(DbContextOptions<BookContext> options): base(options)
    {
    }


    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     var ConnectionString = this.config.GetConnectionString("Default");
    //     optionsBuilder.UseSqlServer(ConnectionString);
    //     base.OnConfiguring(optionsBuilder);
    // }

    // Models
    public DbSet<Author> Authors{ get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookTags> BookTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PriceOffer> PriceOffers { get; set; }
    public DbSet<User> Users { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Book
        modelBuilder.Entity<Book>().HasKey(e=> e.Id);
        modelBuilder.Entity<Book>().HasOne(e=> e.User).WithMany(e=> e.Books).HasForeignKey(e=> e.CreatedByID).IsRequired();
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
        modelBuilder.Entity<Author>().Property(e=> e.Website).HasMaxLength(100);


        // Book Author
        modelBuilder.Entity<BookAuthor>().HasKey(e=> new { e.BookID, e.AuthorID});
        modelBuilder.Entity<BookAuthor>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<BookAuthor>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");
        

        // Tag
        modelBuilder.Entity<Tag>().HasKey(e=> e.Id);
        modelBuilder.Entity<Tag>().Property(e=> e.Name).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Tag>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<Tag>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");
        // modelBuilder.Entity<Tag>().HasOne(e=> e.user).WithMany(e=> e.Tags).HasForeignKey(e=> e.CreatedByID).IsRequired();


        // Book Tags
        modelBuilder.Entity<BookTags>().HasKey(e=> new {e.BookID, e.TagID});
        modelBuilder.Entity<BookTags>().HasOne(e=> e.Tag).WithMany().HasForeignKey(e=> e.TagID).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<BookTags>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<BookTags>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");

        // Review
        modelBuilder.Entity<Review>().HasKey(e=> e.Id);
        modelBuilder.Entity<Review>().Property(e=> e.Comment).HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Review>().Property(e=> e.ReviewerName).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Review>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<Review>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");


        // Users
        modelBuilder.Entity<User>().HasKey(e=> e.Id);

        modelBuilder.Entity<User>().Property(e=> e.Firstname).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<User>().Property(e=> e.Lastname).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<User>().Property(e=> e.Email).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<User>().Property(e=> e.CreatedByID).IsRequired();
        modelBuilder.Entity<User>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<User>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");


        // Price Offer
        modelBuilder.Entity<PriceOffer>().HasKey(e=> e.Id);
        modelBuilder.Entity<PriceOffer>().Property(e=> e.PromotionalText).HasMaxLength(150).IsRequired();
        modelBuilder.Entity<PriceOffer>().Property(e=> e.CreatedByID).IsRequired();
        modelBuilder.Entity<PriceOffer>().Property(e=> e.IsActive).HasDefaultValue(true);
        modelBuilder.Entity<PriceOffer>().Property(e=> e.CreatedOn).HasDefaultValueSql("GETDATE()");


        // just for testing purposes

    }
}