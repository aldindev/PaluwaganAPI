using System.ComponentModel.DataAnnotations;

namespace PaluwaganAPI.ViewModels
{
    public class UserRegistrationDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
    }

}
