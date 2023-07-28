using bookstore.Repositories;

namespace bookstore.Services;

public class AuthorService : IAuthorService
{
    private readonly BookContext context;
    private readonly IAuthorRepository repo;

    public AuthorService(BookContext context, IAuthorRepository repo)
    {
        this.context = context;
        this.repo = repo;
    }
    public async Task<List<Author>> GetAuthors()
    {
        return await repo.GetAuthors();
    }
}