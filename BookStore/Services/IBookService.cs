namespace bookstore.Services;

public interface IBookService
{
    public Task<List<Book>> getBookList();
    public Task<Book> getBook(int BookID);
}
