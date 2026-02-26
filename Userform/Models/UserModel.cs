using System.ComponentModel.DataAnnotations;
using UserForm.Enum;

namespace UserForm.Models
{
    public class UserModel
    {
        public Guid Id { get; set; } 
        
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        
        public UserStatus Status { get; set; } = UserStatus.Active;
    }
}