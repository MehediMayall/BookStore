namespace bookstore.Repositories;

public interface IBookRepository
{
    public Task<List<Book>> GetBooks();
}