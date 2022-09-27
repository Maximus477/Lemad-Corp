using System.ComponentModel.DataAnnotations;
using FluentValidation;
using static LemadDb.Data.Status;

namespace LemadDb.Domain.Entities
{
    public class PowerUnits
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        #region Stats

        #endregion

        [DataType(dataType: DataType.Currency)]
        public decimal Price { get; set; }

        public byte Discount { get; set; }

        [Required]
        public ProductStatus Status { get; set; }
    }

    public class PowerUnitValidator : AbstractValidator<PowerUnits>
    {
        public PowerUnitValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .WithMessage("The name cannot be empty!");

            RuleFor(e => e.Price)
                .NotEmpty().WithMessage("The price cannot be empty!")
                .GreaterThan(0).WithMessage("The price must be higher than 0.0$");

            RuleFor(e => e.Discount)
                .NotEmpty().WithMessage("The discount cannot be empty!")
                .When(e => e.Discount >= 0 && e.Discount <= 100).WithMessage("The discount must be greater or equal and 0 and less or equal than 100");
        }
    }
}
