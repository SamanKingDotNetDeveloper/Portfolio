using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    [Keyless]
    [Table("resumelink")]
    public class ResumeLink
    {
        [Required]
        [Column("resumee")]
        public string Resume { get; set; }
    }
}
