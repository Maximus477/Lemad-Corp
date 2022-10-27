using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace LemadWeb.ViewModels
{
    public class ContactClientForm
    {
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage ="This is not a valid email address")]
        public string Email { get; set; }

        public string Message { get; set; }
    }

    public class ContactClientFormValidator : AbstractValidator<ContactClientForm>
    {
        public ContactClientFormValidator()
        {
            RuleFor(c => c.FullName)
                .NotNull().WithMessage("The name is required to contact us");

            RuleFor(c => c.Email)
                .NotNull().WithMessage("The email is required to contact us");
        }
    }
}
