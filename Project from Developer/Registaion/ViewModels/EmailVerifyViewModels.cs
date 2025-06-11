using System.ComponentModel.DataAnnotations;

namespace Registation.ViewModels
{
    public class EmailVerifyViewModels
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
