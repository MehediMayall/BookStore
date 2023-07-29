namespace bookstore.Controllers;

public class UserController : BaseController
{
    private readonly IUserService service;

    public UserController(IUserService service)
    {
        this.service = service;
    }
}