using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="User Name is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "User Name must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be at between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please verify password.")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
