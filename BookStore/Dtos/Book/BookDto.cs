namespace bookstore.Dtos;

public class BookDto
{
    public int BookID { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; }
    public int NumberOfReviews { get; set; }
}