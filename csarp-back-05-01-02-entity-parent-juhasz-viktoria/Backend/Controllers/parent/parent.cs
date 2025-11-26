using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MyApp.Backend.Controllers.parent
{
    [Index(nameof(Email), IsUnique = true)]

    public class Parent
    {
        [Key]                          //kulcs jelzi, hogy az id az elsodleges kulcs a tablaban
        public Guid Id { get; set; }  //id

        [Required]
        [MaxLength(100, ErrorMessage="a nev max 100 karakter lehet!")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Birthdate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage="az eletkor legalabb 0 kell legyen!")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="ervenytelen emailcim!")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
