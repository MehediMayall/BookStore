using Microsoft.EntityFrameworkCore;

namespace bookstore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext dbContext;
    public BookRepository(BookContext dbContext)
    {
        this.dbContext = dbContext;
    }


    // Loading all books and its related tables using Eager Loading
    public async Task<List<Book>> GetBooks()
    {
        // return await dbContext.Books.Include(e=> new {e.BookAuthors, e.Reviews}).ToListAsync();
        return await dbContext.Books
            .Include(e=>  e.BookAuthors)
            .Include(e=> e.Reviews.Where(r=> r.NumberOfStars>4))
            .Include(e=> e.BookTags) //.ThenInclude(BookTags => BookTags.Tag)
            .Include(e=> e.Promotion)
            .ToListAsync();
    }


    // get a book detail using explicit loading
    public async Task<Book> GetBook(int BookID)
    {
        Book book = await dbContext.Books.Where(b=> b.Id == BookID).FirstOrDefaultAsync();
        this.dbContext.Entry(book).Collection(e=> e.Reviews ).Load();        
        return book;
    }    


    // Select loading. Client-Server query execution in Authors property
    public async Task<List<BookDto>> GetBookList()
    {
        List<BookDto> books = await dbContext.Books
            .Select(
                b=> new BookDto{
                    BookID = b.Id,
                    Title = b.Title,
                    Price = b.Price,
                    Authors = string.Join(", ", b.BookAuthors.OrderBy(a=> a.OrderNo).Select(ba=> ba.Author.Firstname + " " + ba.Author.Lastname)),
                    NumberOfReviews = b.Reviews.Count,
                }
            ).ToListAsync();

        return books;
    }
}