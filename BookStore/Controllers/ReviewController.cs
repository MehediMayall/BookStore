namespace bookstore.Controllers;

public class ReviewController : BaseController
{
    private readonly IReviewService service;

    public ReviewController(IReviewService service)
    {
        this.service = service;
    }
}