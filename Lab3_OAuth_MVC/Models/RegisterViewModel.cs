using System.ComponentModel.DataAnnotations;

namespace Lab3_OAuth_MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(
            @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,16}$",
            ErrorMessage = "Password must contain uppercase letter, digit and symbol"
        )]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [Phone]
        [RegularExpression(@"^\+380\d{9}$")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
