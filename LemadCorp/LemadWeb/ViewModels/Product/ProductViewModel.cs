using FluentValidation;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.ComponentModel.DataAnnotations;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewModels.Product
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public ProductStatus Status { get; set; }

        public byte[] Photo { get; set; }
        public int MaxContractTime { get; set; }

        public DateTime DateNaissance { get; set; }
        public string Description { get; set; } = "";
        public string Quote { get; set; } = "";
    }

    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .WithMessage("The name cannot be empty!");

            RuleFor(e => e.Price)
                .NotEmpty().WithMessage("The price cannot be empty!");

            RuleFor(e => e.Price)
                .GreaterThan(0).WithMessage("The price must be higher than $0.0");

            RuleFor(e => e.Discount)
                .NotEmpty().WithMessage("The discount cannot be empty!");

            RuleFor(e => e.Discount)
                .GreaterThanOrEqualTo(0)
                .WithMessage("The discount must be between 0 and 100");

            RuleFor(e => e.Discount)
                .LessThanOrEqualTo(100)
                .WithMessage("The discount must be between 0 and 100");

            RuleFor(e => e.MaxContractTime)
                .NotEmpty().WithMessage("The id cannot be empty!");

            RuleFor(e => e.MaxContractTime)
                .GreaterThanOrEqualTo(0).WithMessage("The contract time must be between 0 and 25");

            RuleFor(e => e.MaxContractTime)
                .LessThanOrEqualTo(25).WithMessage("The contract time must be between 0 and 25");

            RuleFor(e => e.DateNaissance)
                .NotEmpty().WithMessage("The date cannot be empty!");

            RuleFor(e => e.DateNaissance)
                .LessThan(DateTime.Now).WithMessage("The date must be before today!");
        }
    }
}
