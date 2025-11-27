using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;
using MyApp.Backend.Models;
using Mysqlx;

namespace MyApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppInMemoryContext _context = new AppInMemoryContext();

        // 1. osszes termek szama:
        [HttpGet("products/count/all")]
        public async Task<IActionResult> GetAllProducts()
        {
            int eredmeny = await _context.Products.CountAsync();
            return Ok(new {eredmeny});
        }

        // 2. 1000fr alatti termekek szama:
        [HttpGet("products/count/price/less/1000")]
        public async Task<IActionResult> Below1000()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.Price < 1000);
            return Ok(new {eredmeny});
        }

        //3. 1000 ft alatti aktiv termekek szama:
        [HttpGet("products/count/price/active/1000")]

        public async Task<IActionResult> Below1000Active()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.IsActive);
            return Ok(new {eredmeny});
        }

        //4. lejarati datumos termekek:

        [HttpGet("products/count/with-expiration")]

        public async Task<IActionResult> WithExpiration()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.ExpirationDate.HasValue);
            return Ok(new {eredmeny});
        }

        //5. vonalkod nelkuli termekek:

        [HttpGet("products/count/no-barcode")]

        public async Task<IActionResult> NoBarcode()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.Barcode == null);
            return Ok(new {eredmeny});
        }

        //6. keszlettel rendelkezo termekek:
        [HttpGet("products/count/in-stock")]

        public async Task<IActionResult> InStock()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.QuantityInStock < 1);
            return Ok(new {eredmeny});
        }

        //7. nincs kategorizalva:
        [HttpGet("products/count/nocategory/{category}")]
        
        public async Task<IActionResult> NoCategory()
        {
            int eredmeny = await _context.Products.CountAsync(p => p.Category == null);
            return Ok(new {eredmeny});
        }

        //8. ar feletti termekek szama:
        [HttpGet("products/count/price/greater/{minPrice}")]

        public async Task<IActionResult> AbovePrice(decimal minPrice)
        {
            int eredmeny = await _context.Products.CountAsync(p => p.Price > minPrice);
            return Ok(new {eredmeny});
        }

        //9. ertekeles:
        [HttpGet("products/count/rating/{rating}")]

        public async Task<IActionResult> Rating(int rating)
        {
            int eredmeny = await _context.Products.CountAsync(p => p.Rating > rating);
            return Ok(new {eredmeny});
        }

        //10. adott napon letrehozottak szama:
        [HttpGet("products/count/created/{yyyy}-{MM}-{dd}")]
        
        public async Task<IActionResult> CreatedDate(int yyyy, int MM, int dd)
        {
            DateTime targetDate = new DateTime(yyyy, MM, dd);
            int eredmeny = await _context.Products.CountAsync(p => p.CreatedDate == targetDate);
            return Ok(new {eredmeny});
        }
    }
}