namespace bookstore.Dtos;

public class BookDto
{
    public int BookID { get; set; }
    public string? Title { get; set; }
    
    public DateTime PublishedOn { get; set; }
    public decimal Price { get; set; }
    public string PromotionalText { get; set; }
    public decimal ActualPrice { get; set; }
    public string Authors { get; set; }

    public double? AverageStar { get; set; }
    public int NumberOfReviews { get; set; }

    public string[] Tags { get; set; }
}