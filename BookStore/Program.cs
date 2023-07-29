global using bookstore.Dtos;
global using bookstore.models;
global using bookstore.Services;
using bookstore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// register dbcontext
builder.Services.AddDbContext<BookContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


// Register Services
// Book
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IBookRepository, BookRepository>();

// Author
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();

// Review
builder.Services.AddTransient<IReviewService, ReviewService>();
// builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();

// Promotion
builder.Services.AddTransient<IPromotionService, PromotionService>();
// builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();

// Tag
builder.Services.AddTransient<ITagService, TagService>();
// builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();

// User
builder.Services.AddTransient<IUserService, UserService>();
// builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
