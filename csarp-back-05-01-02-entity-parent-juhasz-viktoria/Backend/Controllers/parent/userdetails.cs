using K4os.Compression.LZ4.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Backend.Controllers.parent
{
    [Index(nameof(Email), IsUnique = true)]
    public class UserDetails
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PhoneNumber {  get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    }
}
