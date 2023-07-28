namespace bookstore.models;

public class BookAuthor : BaseModel
{
    public int BookID { get; set; }
    public int AuthorID { get; set; }
    public int OrderNo { get; set; }
}