namespace bookstore.models;

public class Book : BaseModel
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public string Publisher { get; set; } = "";
    public string? ImageURL { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishedOn { get; set; }


    // Relationship
    public User User{ get; set; }
    public PriceOffer Promotion { get; set; }
    public ICollection<BookAuthor> BookAuthors { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<BookTags> BookTags { get; set; }



}