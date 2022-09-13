using System.ComponentModel.DataAnnotations;

namespace LemadWeb.ViewModels.Account
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
