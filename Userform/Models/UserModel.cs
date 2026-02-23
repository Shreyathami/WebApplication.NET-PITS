using System.ComponentModel.DataAnnotations;

namespace UserForm.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
    }
}