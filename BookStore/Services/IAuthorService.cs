namespace bookstore.Services;

public interface IAuthorService
{
    Task<List<Author>> GetAuthors();
}