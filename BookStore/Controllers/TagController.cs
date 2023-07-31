using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

public class TagController : BaseController
{
    private readonly ITagService service;

    public TagController(ITagService service)
    {
        this.service = service;
    }

    [HttpGet]
    [Route("/api/tag/save")]
    public async Task<ActionResult<ResponseDto>> Save(Tag tag)
    {
        try
        {
            return GetResponse( await service.Save(tag));
        }
        catch (Exception ex){ return GetResponse(ex);}
    }
}