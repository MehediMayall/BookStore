namespace bookstore.models;

public class PriceOffer: BaseModel
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public decimal NewPrice { get; set; }
    public string? PromotionalText { get; set; }
}