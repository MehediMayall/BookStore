namespace bookstore.Repositories;

public interface IBookRepository
{
    public Task<List<Book>> GetBooks();
    public Task<Book> GetBook(int BookID);

    public Task<List<BookDto>> GetBookList();
}