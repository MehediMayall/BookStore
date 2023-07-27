// See https://aka.ms/new-console-template for more information
using BookStore.models;
using Microsoft.EntityFrameworkCore;

using (var db = new BookContext())
{
    foreach(var book in db.Books.AsNoTracking().Include(x => x.Author))
    {
        Console.WriteLine($"Name: {book.Title}, Author: {book.Author.Name}");
    }

    var mybook = db.Books.Include(a=> a.Author).Single(b=> b.Title == "Domain Driven Design");
    mybook.PublishedOn = new DateTime(2017, 5, 20);
    mybook.Author.Email = "EricEvans@gmail.com";
    db.SaveChanges();

    Console.WriteLine($"Title: {mybook.Title}, Author: {mybook.Author.Name}, Published Date: {mybook.PublishedOn.ToShortDateString()}");

}

Console.WriteLine("<- end of the programe ->");

