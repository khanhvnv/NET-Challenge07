using Microsoft.EntityFrameworkCore;
using CategoryApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/* builder.Services.AddHttpClient<CategoryService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5000");
}); */


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/categories", async (ApplicationDbContext context) =>
{
    var categories = await context.Categories.ToListAsync();
    return categories;
})
.WithName("GetCategories")
.WithOpenApi();

app.MapGet("/api/products", async (ApplicationDbContext context) =>
{
    var products = await context.Products.ToListAsync();
    return products;
})
.WithName("GetProducts")
.WithOpenApi();

app.Run();
