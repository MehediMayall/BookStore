using Microsoft.EntityFrameworkCore;

namespace bookstore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext dbContext;
    public BookRepository(BookContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Book>> GetBooks()
    {
        // return await dbContext.Books.Include(e=> new {e.BookAuthors, e.Reviews}).ToListAsync();
        return await dbContext.Books
            .Include(e=>  e.BookAuthors)
            .Include(e=> e.Reviews)
            .Include(e=> e.BookTags) //.ThenInclude(BookTags => BookTags.Tag)
            .Include(e=> e.Promotion)
            .ToListAsync();
    }    
}