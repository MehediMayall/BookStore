using bookstore.Repositories;

namespace bookstore.Services;

public class TagService: ITagService
{
    private readonly IGenericRepository<Tag> repo;

    public TagService(IGenericRepository<Tag> repo)
    {
        this.repo = repo;
    }

    public async Task<Tag> Save(Tag tag)
    {
        return await repo.Save(tag);
    }
}