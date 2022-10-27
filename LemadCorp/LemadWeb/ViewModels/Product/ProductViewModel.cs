using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewModels.Product
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public byte Discount { get; set; }

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
                .NotEmpty().WithMessage("The price cannot be empty!")
                .GreaterThan(0).WithMessage("The price must be higher than $0.0");

            RuleFor(e => (int)e.Discount)
                .NotEmpty().WithMessage("The discount cannot be empty!")
                .GreaterThanOrEqualTo(0).WithMessage("The discount must be greater or equal than 0 and smaller than 100");

            RuleFor(e => (int)e.Discount)
                .LessThanOrEqualTo(100).WithMessage("The discount must be smaller or equal than 100");
        }
    }
}
