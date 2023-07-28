namespace bookstore.models;

public class Tag : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }="";

    public ICollection<BookTags> BookTags { get; set; }
}