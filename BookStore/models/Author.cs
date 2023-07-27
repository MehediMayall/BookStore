namespace bookstore.models;

public class Author : BaseModel
{
    public int Id { get; set; }
    public string Firstname { get; set;} = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    
}