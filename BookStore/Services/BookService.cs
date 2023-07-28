using Microsoft.EntityFrameworkCore;
using bookstore.Repositories;

namespace bookstore.Services;

public class BookService : IBookService
{

    private readonly BookContext dbContext;
    private readonly IBookRepository repo;

    public BookService(BookContext dbContext, IBookRepository repo)
    {
        this.dbContext = dbContext;
        this.repo = repo;
    }

    public async Task<Book> getBook(int BookID)
    {
        return await this.repo.GetBook(BookID);
    }

    public async Task<List<Book>> getBookList()
    {
        return await repo.GetBooks();
    }
}
