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
        return await dbContext.Books.ToListAsync();
    }
}