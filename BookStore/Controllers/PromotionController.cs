using bookstore.Services;

namespace bookstore.Controllers;

public class PromotionController : BaseController
{
    private readonly IPromotionService service;

    public PromotionController(IPromotionService service)
    {
        this.service = service;
    }
}