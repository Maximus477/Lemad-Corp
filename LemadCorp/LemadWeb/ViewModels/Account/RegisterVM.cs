using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace LemadWeb.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }

        #region Address
        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }
        #endregion
    }

    public class ProductValidator : AbstractValidator<RegisterVM>
    {
        public ProductValidator()
        {
            RuleFor(customer => customer.Password)
            .Equal(customer => customer.PasswordConfirmation)
            .When(customer => !String.IsNullOrWhiteSpace(customer.Password))
            .WithMessage("The passwords did not match!");
        }
    }
}
