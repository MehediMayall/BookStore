namespace bookstore.Services;

public interface ITagService
{
    public Task<Tag> Save(Tag tag);
}