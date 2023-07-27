namespace bookstore.models;

public class User : BaseModel
{
    public int Id { get; set;}
    public string Firstname { get; set; } = "";
    public string Lastname { get; set; } = "";
    public string Email { get; set; } = "";

    public ICollection<Tag> Tags { get; set; }
}