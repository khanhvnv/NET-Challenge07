using System;

namespace SharedLibrary.Models;

public class ProductDto
{
    public int Id { get; set; }
    public string ? Name { get; set; }
    public string ? Description { get; set; }
    public int Price { get; set; }
    public string ? ImageURL { get; set; }
    public DateOnly CreatedDate { get; set; }
    public DateOnly UpdatedDate { get; set; }
    public int CategoryId { get; set; }
}
