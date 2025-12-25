using System.ComponentModel.DataAnnotations;

namespace Lab3_OAuth_MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(500, ErrorMessage = "Max 500 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(
            @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,16}$",
            ErrorMessage = "Password must contain at least 1 digit, 1 symbol, 1 uppercase letter (8-16 chars)"
        )]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Ukrainian phone format required")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
