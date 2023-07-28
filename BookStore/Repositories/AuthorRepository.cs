using Microsoft.EntityFrameworkCore;
namespace bookstore.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly BookContext dbContext;

    public AuthorRepository(BookContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Author>> GetAuthors()
    {
        return await this.dbContext.Authors.AsNoTracking().ToListAsync();
    }
}