using System.ComponentModel.DataAnnotations;

namespace LemadWeb.Models
{
    public class ContactClientForm
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage ="This is not a valid email address")]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
