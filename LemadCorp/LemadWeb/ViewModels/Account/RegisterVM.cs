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
        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
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

            RuleFor(c => c.FirstName)
                .Length(1, 32)
                .WithMessage("The first name must be between 1 and 32 characters");

            RuleFor(c => c.LastName)
                .Length(1, 32)
                .WithMessage("The last name must be between 1 and 32 characters");

            RuleFor(c => c.PhoneNumber)
                .Matches(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")
                .WithMessage("Please enter a valid phone number");

            RuleFor(c => c.Address)
                .Length(1, 32)
                .WithMessage("The address must be between 1 and 32 characters");
            
            RuleFor(c => c.City)
                .Length(1, 32)
                .WithMessage("The city must be between 1 and 32 characters");

            RuleFor(c => c.Province)
                .Length(1, 32)
                .WithMessage("The province must be between 1 and 32 characters");

            RuleFor(c => c.Country)
                .Length(1, 32)
                .WithMessage("The country must be between 1 and 32 characters");
                
            RuleFor(c => c.PostalCode)
                .Matches(@"/^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z][ -]?\d[ABCEGHJ-NPRSTV-Z]\d$/i")
                .WithMessage("Please enter a valid zip code");
        }
    }
}
