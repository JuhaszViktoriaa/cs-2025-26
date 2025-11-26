using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;
using MyApp.Backend.Models;

namespace MyApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppInMemoryContext _context = new AppInMemoryContext();

        // 1. feladat: Hány tanár van az adatbázisban?
        [HttpGet("products")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //return await _context.Products.ToListAsync();
            return Ok(_context.Products.ToListAsync());
        }
        //hany termek talalhato osszesen az adatbazisban?
        //
        [HttpGet("count")]
        public async Task<IActionResult> GetTermekSzam()
        {
            return Ok(await _context.Products.CountAsync());        //async vegrehajtja az elotte levo utasitast - itt count();
        }
        //Számold meg, hány aktív (IsActive = true) termék található!
        [HttpGet("count/active")]
        public async Task<IActionResult> GetAktivE()
        {
            return Ok(await _context.Products.CountAsync(p => p.IsActive));        //_context == maga az adatbazis
        }
        //Számold meg, hány termék tartozik egy adott kategóriába (pl. Pékáru)!
        [HttpGet("count/category/{Kategorianev}")]
        public async Task<IActionResult> KategoriaSzamolo(string KategoriaNev)
        {
            string kisbetuskategorianev=KategoriaNev.Trim().ToLower();
            //return Ok(await _context.Products.CountAsync(p => p.Category == KategoriaNev));
            return Ok(await _context.Products.CountAsync(p => p.Category!=null && p.Category.ToLower() == kisbetuskategorianev));
        }
        //szamoljuk meg hany termeknek van lejarati datuma

        [HttpGet("count/expired")]
        public async Task<IActionResult> LejartTermekekSzama()
        {
            //return Ok(await _context.Products.CountAsync(p => p.ExpirationDate!=null));
            //return Ok(await _context.Products.CountAsync(p => p.ExpirationDate.HasValue));
            return Ok(await _context.Products.CountAsync(p => p.ExpirationDate != null && p.ExpirationDate<DateTime.UtcNow));
        }

        // meghatarozott ertek alatti aras termekek dbszama

        [HttpGet("api/count/price/less/{maxprice}")]

        public async Task<IActionResult> Ertekalattiar(int maxar)
        {
            return Ok(await _context.Products.CountAsync(p => p.Price < maxar));
        }

        //decimal? string? int? => lehet h nincs hozza ertek        minden olyan erteket, ami lehet null, vizsgalni kell, hogy null-e
        //Számold meg, hány termék értékelése(`Rating`) nagyobb egy adott értéknél(pl. 4.5)!
        //Végpont(példa 4.5-re) :**  GET /api/products/count/rating/greater/4.5

        [HttpGet("api/products/count/rating/greater/4.5")]

        public async Task<IActionResult> Negyesfelfelettiertekeles()
        {
            return Ok(await _context.Products.CountAsync(p => p.Rating < 4.5m));
        }
    }
}
