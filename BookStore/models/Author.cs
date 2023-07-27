namespace BookStore.models;

public class Author
{
    public int AuthorID { get; set; }
    public string Name { get; set;}
    public string Email { get; set;}

    public string URL { get; set; }

    public List<Book> Books { get; set; }
}