namespace bookstore.Controllers;

public class TagController : BaseController
{
    private readonly ITagService service;

    public TagController(ITagService service)
    {
        this.service = service;
    }
}