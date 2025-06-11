using System.ComponentModel.DataAnnotations;

namespace Registation.ViewModels
{
    public class ChangePasswordViewModels
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "New Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm New Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }
    }   
}
