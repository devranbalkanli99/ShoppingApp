using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public String? Password { get; init; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public String? ConfirmPassword { get; init; }
    }

}