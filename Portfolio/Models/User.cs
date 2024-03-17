using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    [Keyless]
    [Table("userr")]
    public class User
    {
        [Required]
        [Column("aboutme")]
        public string AboutMe { get; set; }
    }
}
