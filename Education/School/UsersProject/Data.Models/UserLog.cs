using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class UserLog
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int LogId { get; set; }

        [Required]
        [ForeignKey(nameof(LogId))]
        public Log Log { get; set; } = null!;
    }
}
