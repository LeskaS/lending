using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("Program")]
        public int? ProgramId { get; set; }

        public string? Photo { get; set; }
        public string Profession { get; set; }
        public string? Description { get; set; }
        public string? Social { get; set; }
        public string? SocialDescription { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public Program? Program { get; set; }
    }
}