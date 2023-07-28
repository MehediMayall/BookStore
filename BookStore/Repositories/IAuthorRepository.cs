namespace bookstore.Repositories;

public interface IAuthorRepository
{
    Task<List<Author>> GetAuthors();
}