using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("projects")]
    public class Projects
    {
        [Required]
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column ("imagee")]
        public string Image { get; set; }

        [Required]
        [Column("githublink")]
        public string GitHub { get; set; }
    }
}
