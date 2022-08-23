using System.ComponentModel.DataAnnotations;

namespace LemadWeb.ViewModel.Account
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }

        public byte[] Photo { get; set; }
    }
}
