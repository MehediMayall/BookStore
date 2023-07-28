using Microsoft.EntityFrameworkCore;

namespace bookstore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext dbContext;
    public BookRepository(BookContext dbContext)
    {
        this.dbContext = dbContext;
    }


    // Loading all books and its related tables using Eager Loading
    public async Task<List<Book>> GetBooks()
    {
        // return await dbContext.Books.Include(e=> new {e.BookAuthors, e.Reviews}).ToListAsync();
        return await dbContext.Books
            .Include(e=>  e.BookAuthors)
            .Include(e=> e.Reviews.Where(r=> r.NumberOfStars>4))
            .Include(e=> e.BookTags) //.ThenInclude(BookTags => BookTags.Tag)
            .Include(e=> e.Promotion)
            .ToListAsync();
    }


    // get a book detail using explicit loading
    public async Task<Book> GetBook(int BookID)
    {
        Book book = await dbContext.Books.Where(b=> b.Id == BookID).FirstOrDefaultAsync();
        this.dbContext.Entry(book).Collection(e=> e.Reviews ).Load();        
        return book;
    }    
}