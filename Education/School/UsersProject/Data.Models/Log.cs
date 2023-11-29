using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ActivityTime { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(25)]
        public string Activity { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }
    }
}
