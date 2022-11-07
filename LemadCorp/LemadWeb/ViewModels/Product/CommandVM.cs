using LemadDb.Domain.User;
using LemadDb.Domain.Entities;
using System.Collections.Generic;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace LemadWeb.ViewModels.Product
{
    public class CommandVM
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool AddNewAddress { get; set; }
        public Guid SelectedAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Total { get; set; }
        public string TotalDiscount { get; set; }
        public string TotalWithDiscount { get; set; }
        public string TotalWithTaxes { get; set; }
        public Guid CommandGuid { get; set; }
        public Dictionary<int, int> CommandDictionary { get; set; }
        public List<LemadDb.Domain.Entities.Product> Products { get; set; } = new List<LemadDb.Domain.Entities.Product>();

        public CommandVM()
        {
            
        }

        public class CommandValidator : AbstractValidator<CommandVM>
        {
            public CommandValidator()
            {
                RuleFor(e => e.FirstName)
                    .NotEmpty()
                    .WithMessage("The first name cannot be empty!");

                RuleFor(e => e.LastName)
                    .NotEmpty()
                    .WithMessage("The last name cannot be empty!");

                RuleFor(e => e.Email)
                    .NotEmpty()
                    .WithMessage("The email cannot be empty!");

                RuleFor(e => e.Phone)
                    .NotEmpty()
                    .WithMessage("The phone number cannot be empty!");

                RuleFor(e => e.Address)
                    .NotEmpty()
                    .WithMessage("The address cannot be empty!");

                RuleFor(e => e.City)
                    .NotEmpty()
                    .WithMessage("The city cannot be empty!");

                RuleFor(e => e.Province)
                    .NotEmpty()
                    .WithMessage("The province cannot be empty!");

                RuleFor(e => e.Country)
                    .NotEmpty()
                    .WithMessage("The country cannot be empty!");

                RuleFor(e => e.PostalCode)
                    .NotEmpty()
                    .WithMessage("The postal code cannot be empty!");

                RuleFor(e => e.Phone)
                    .Matches(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")
                    .WithMessage("The phone number is not valid!");
            }
        }

    }
}
