using System.ComponentModel.DataAnnotations;

namespace ShortUrlMVC.PL.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember login?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
