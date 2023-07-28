using bookstore.Services;
using Microsoft.AspNetCore.Mvc;
namespace bookstore.Controllers;

public class BookController: BaseController
{
    private readonly IBookService service;

    public BookController(IBookService service)
    {
        this.service = service;
    }


    [HttpGet]
    [Route("/")]
    public async Task<IActionResult> Index()
    {
        return Ok("Welcome to BookStore API");
    }


    [HttpGet]
    [Route("/api/book/list")]
    public async Task<ActionResult<ResponseDto>> getBookList()
    {
        try
        {
            return GetResponse(await this.service.getBookList());
        }
        catch (Exception ex) { return GetResponse(ex);}
    }


    [HttpGet]
    [Route("/api/book/detail/{id}")]
    public async Task<ActionResult<ResponseDto>> getBook(int id)
    {
        try
        {
            return GetResponse(await this.service.getBook(id));
        }
        catch(Exception ex) { return GetResponse(ex);}

    }



}