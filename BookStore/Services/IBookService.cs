namespace bookstore.Services;

public interface IBookService
{
    public Task<List<Book>> getBooks();
    public Task<Book> getBook(int BookID);
    public Task<List<BookDto>> getBookList();
}
