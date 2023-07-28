namespace bookstore.models;

public class BookTags : BaseModel
{
    public int BookID { get; set; }
    public int TagID { get; set; }
    // public Tag Tag { get; set; }
}