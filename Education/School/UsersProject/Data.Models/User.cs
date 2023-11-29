using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
            Logs = new HashSet<Log>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(40)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(345)]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public ICollection<Log> Logs { get; set; }
    }
}
