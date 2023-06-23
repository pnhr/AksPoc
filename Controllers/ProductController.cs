using AksPoc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AksPoc.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Laptop", "Monitor", "Mouse", "Keypad", "UPS", "Speakers", "Pen", "Printer", "Pendrive", "RAM", "Hard Drive"
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    public IEnumerable<Product> GetProducts()
    {
        return Enumerable.Range(1, 5).Select(index => new Product
        {
            Id = Random.Shared.Next(1, 55),
            Name = Summaries[Random.Shared.Next(Summaries.Length)],
            Count = 44 //Random.Shared.Next(10, 55)
        })
        .ToArray();
    }
}
