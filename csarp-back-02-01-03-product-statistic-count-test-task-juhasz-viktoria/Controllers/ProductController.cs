using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;
using MyApp.Backend.Models;
using SQLitePCL;
using System.Globalization;

namespace MyApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppInMemoryContext _db= new AppInMemoryContext();

        // 1) Inaktív termékek száma
        // GET /api/products/count/inactive
        [HttpGet("count/inactive")]
        public async Task<IActionResult> CountInactive(CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => !(p.IsActive));
            return Ok(new {eredmeny});
        }

        // 2) Lejárati dátum nélküli termékek
        // GET /api/products/count/no-expiration
        [HttpGet("count/no-expiration")]
        public async Task<IActionResult> CountNoExpiration(CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.ExpirationDate == null);
            return Ok(new {eredmeny});
        }

        // 3) Vonalkóddal rendelkező termékek
        // GET /api/products/count/with-barcode
        [HttpGet("count/with-barcode")]
        public async Task<IActionResult> CountWithBarcode(CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.Barcode != null);
            return Ok(new {eredmeny});
        }

        // 4) Készlet nélküli (0 darab) termékek
        // GET /api/products/count/out-of-stock
        [HttpGet("count/out-of-stock")]
        public async Task<IActionResult> CountOutOfStock(CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.QuantityInStock == 0, cancellationToken: ct);
            return Ok(new {eredmeny});
        }

        // 5) Adott kategóriájú, adott ár alatti termékek
        // GET /api/products/count/category/{category}/price/less/{maxPrice}
        [HttpGet("count/category/{category}/price/less/{maxPrice:decimal}")]
        public async Task<IActionResult> CountByCategoryAndPriceLess(string category, decimal maxPrice, CancellationToken ct)
        {
            int count = await _db.Products.Where(p => p.Category == category && p.Price < maxPrice).CountAsync(cancellationToken: ct);
            return Ok(new { category, maxPrice, count });
        }

        // 6) Névben részszóra illeszkedő termékek (case-insensitive)
        // GET /api/products/count/name/contains/{term}
        [HttpGet("count/name/contains/{term}")]
        public async Task<IActionResult> CountNameContains(string term, CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => EF.Functions.Like(p.Name, $"%{term}%"), cancellationToken: ct);
            //int eredmeny = await _db.Products.ContainsAsync(p => p.Name, term).CountAsync(CancellationToken: ct);
            return Ok(new {eredmeny, term});
        }

        // 7) Értékelési tartomány [min, max], null érték kizárva
        // GET /api/products/count/rating/between/{min}/{max}
        [HttpGet("count/rating/between/{min:decimal}/{max:decimal}")]
        public async Task<IActionResult> CountRatingBetween(decimal min, decimal max, CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.Rating != null && p.Rating >= min && p.Rating <= max, cancellationToken: ct);
            return Ok(new { eredmeny, min, max });
        }

        // 8) Hamarosan lejáró termékek (0..days napon belül)
        // GET /api/products/count/expiring-in-days/{days}
        [HttpGet("count/expiring-in-days/{days:int}")]
        public async Task<IActionResult> CountExpiringInDays(int days, CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.ExpirationDate < DateTime.UtcNow, cancellationToken: ct);
            return Ok(new {eredmeny});
        }

        // 9) Súlytartomány + aktív státusz
        // GET /api/products/count/weight/between/{min}/{max}/active
        [HttpGet("count/weight/between/{min:double}/{max:double}/active")]
        public async Task<IActionResult> CountActiveByWeightBetween(double min, double max, CancellationToken ct)
        {
            int eredmeny = await _db.Products.CountAsync(p => p.IsActive == true && p.WeightKg != null && p.WeightKg>= min && p.WeightKg <= max, cancellationToken: ct);
            return Ok(new {eredmeny, min, max});
        }

        // 10) CreatedDate adott napra (időkomponens figyelmen kívül)
        // GET /api/products/count/created-on/{yyyy}-{MM}-{dd}
        [HttpGet("count/created-on/{yyyy}-{MM}-{dd}")]
        public async Task<IActionResult> CountCreatedOn(int year, int month, int day, CancellationToken ct)
        {
            DateTime date = new DateTime(year, month, day);
            DateTime nextDate = date.AddDays(1);

            int eredmeny = await _db.Products.CountAsync(p => p.CreatedDate >= date && p.CreatedDate < nextDate, cancellationToken: ct);

            return Ok(new { eredmeny, date = date.ToString("yyyy-MM-dd") });
            // yyyy-MM-dd elvárt formátum;
        }
    }
}