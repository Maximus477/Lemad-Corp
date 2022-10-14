using FluentValidation;
using System.ComponentModel.DataAnnotations;
using static LemadDb.Data.Category;
using static LemadDb.Data.Status;

namespace LemadWeb.ViewModels.Product
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public byte Discount { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public ProductStatus Status { get; set; }

        //public byte[] Photo { get; set; }
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

            RuleFor(e => e.Discount)
                .NotEmpty().WithMessage("The discount cannot be empty!")
                .When(e => e.Discount >= 0 && e.Discount <= 100).WithMessage("The discount must be greater or equal and 0 and less or equal than 100");

            RuleFor(e => e.Status)
                .NotEmpty()
                .WithMessage("The Status cannot be empty!");

            RuleFor(e => e.ProductCategory)
                .NotEmpty()
                .WithMessage("The type cannot be empty!");
        }
    }
}
