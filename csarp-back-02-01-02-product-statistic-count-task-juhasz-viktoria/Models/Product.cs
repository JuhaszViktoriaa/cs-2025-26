namespace MyApp.Backend.Models
{
    /// <summary>
    /// Egy terméket reprezentál a rendszerben.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// A termék egyedi azonosítója.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// A termék neve (kötelező mező).
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A termék részletes leírása (opcionális).
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// A termék ára. Pénzügyi értékek tárolására decimal típust használunk.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// A készleten lévő mennyiség.
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// A termék súlya kilogrammban (opcionális).
        /// </summary>
        public double? WeightKg { get; set; }

        /// <summary>
        /// Jelzi, hogy a termék aktív-e (true) vagy inaktív (false).
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// A dátum és időpont, amikor a termék létre lett hozva.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// A termék lejárati dátuma (ha van).
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// A termék vonalkódja (pl. EAN-13). Opcionális mező.
        /// </summary>
        public string? Barcode { get; set; }

        /// <summary>
        /// Belső cikkszám, egyedi azonosító üzleti logikához.
        /// </summary>
        public string? ProductCode { get; set; }

        /// <summary>
        /// A termék kategóriája (pl. "Élelmiszer", "Elektronika").
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Vásárlói értékelés (0.0 - 5.0 skálán).
        /// </summary>
        public decimal? Rating { get; set; }

        /// <summary>
        /// A termék képének elérési útja (URL).
        /// </summary>
        public string? ImageUrl { get; set; }
    }
}
