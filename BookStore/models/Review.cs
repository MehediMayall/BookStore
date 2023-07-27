namespace bookstore.models;

public class Review: BaseModel
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string ReviewerName { get; set; } = "";
    public int NumberOfStars { get; set; }
    public string Comment { get; set; } = "";

}