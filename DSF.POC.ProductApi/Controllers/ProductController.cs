using Microsoft.AspNetCore.Mvc;

namespace DSF.POC.ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly Product[] Products = new[]
        {
            new Product{ ProductId = 0,ProductDescription="Product 0"},
            new Product{ ProductId = 2,ProductDescription="Product 2"},
            new Product{ ProductId = 3,ProductDescription="Product 3"},
            new Product{ ProductId = 4,ProductDescription="Product 4"},
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return Products;
        }
    }
}