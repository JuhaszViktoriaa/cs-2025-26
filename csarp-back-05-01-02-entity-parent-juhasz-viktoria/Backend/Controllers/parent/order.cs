using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Controllers.parent
{
    [Index(nameof(Ordercode), IsUnique = true)]
    public class order
    {
        //Id uniqueidentifier(GUID)
        //OrderDate datetime2   DEFAULT(getutcdate())
        //OrderCode   nvarchar(50)    UNIQUE, NOT NULL


        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="kotelezo nevet felvinni!")]
        public string Customer { get; set; } = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "kotelezo termkeknevet felvinni!")]
        public string Productname { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "a darabszam nem lehet negativ!")]
        public int Quantity { get; set; }

        //[Range(18, 2, ErrorMessage = "az ar nem lehet negativ!")]
        [Range(0, double.MaxValue, ErrorMessage = "az ar nem lehet negativ!")]
        public decimal Unitprice { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Orderdate { get; set; } = DateTime.UtcNow;

        [Required]
        public string Ordercode { get; set; } = string.Empty;
    }
}
