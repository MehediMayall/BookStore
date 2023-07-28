using bookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

public class AuthorController : BaseController
{
    private readonly IAuthorService service;

    public AuthorController(IAuthorService service)
    {
        this.service = service;
    }

    [HttpGet]
    [Route("/api/author/list")]
    public async Task<ActionResult<ResponseDto>> GetAuthors()
    {
        try
        {
            return GetResponse( await service.GetAuthors());
        }
        catch (Exception ex){ return GetResponse(ex);}
    }

    
}