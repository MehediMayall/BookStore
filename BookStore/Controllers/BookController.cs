using Microsoft.AspNetCore.Mvc;
namespace bookstore.Controllers;

public class BookController: BaseController
{

    [HttpGet]
    [Route("/")]
    public async Task<IActionResult> Index()
    {
        return Ok("Welcome to BookStore API");
    }
}