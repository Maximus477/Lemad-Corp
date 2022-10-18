using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using static LemadDb.Data.Status;
using static LemadDb.Data.Category;
using LemadDb.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace LemadDb.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }
        public int MaxContractTime { get; set; }

        public DateTime DateNaissance { get; set; }
        public string Description { get; set; } = "";
        public string Quote { get; set; } = "";

        public ProductCategory ProductCategory { get; set; }

        public ProductStatus Status { get; set; }

        public string Path { get; set; }

        public byte[] Photo { get; set; }

        #region Stats

        #endregion


        public string GetDate
        {
            get
            {
                var age = DateTime.Today.Year - DateNaissance.Year;
                if (DateNaissance.Date > DateTime.Today.AddYears(-age)) age--;

                if (ProductCategory == Category.ProductCategory.POWERUNIT)
                {
                    return "Creation date: " + DateNaissance.ToString("dd MMM yyyy") + " (" + age.ToString() + " ans)";
                } else
                {
                    return "Date of birth: " + DateNaissance.ToString("dd MMM yyyy") + " (" + age.ToString() + " ans)";
                }
            }
        }
        public string GetCategoryName
        {
            get
            {
                switch (ProductCategory)
                {
                    case Category.ProductCategory.DRIVER:
                        return "Driver";
                        break;
                    case Category.ProductCategory.POWERUNIT:
                        return "Power unit";
                        break;
                    case Category.ProductCategory.PRINCIPAL:
                        return "Team principal";
                        break;
                    case Category.ProductCategory.TECHNICALCHIEF:
                        return "Technical chief";
                        break;
                    case Category.ProductCategory.RACEENGINEER:
                        return "Race engineer";
                        break;
                    default:
                        return "";
                        break;
                }
            }
        }
        public decimal ActualPrice
        {
            get
            {
                return Price - (((decimal)Discount / 100) * Price);
            }
        }
        public decimal DiscountAmount
        {
            get
            {
                return ((decimal)Discount / 100) * Price;
            }
        }
        internal static long MaxThreeSignificantDigits(long x)
        {
            int i = (int)Math.Log10(x);
            i = Math.Max(0, i - 2);
            i = (int)Math.Pow(10, i);
            return x / i * i;
        }
        public string FormatNumber(decimal num)
        {
            num = MaxThreeSignificantDigits((long)num);
            Double dnum = Decimal.ToDouble(num);

            if (num >= 100000000)
                return (dnum / 1000000D).ToString("0.#M");
            if (num >= 1000000)
                return (dnum / 1000000D).ToString("0.##M");
            if (num >= 100000)
                return (dnum / 1000D).ToString("0k");
            if (num >= 100000)
                return (dnum / 1000D).ToString("0.#k");
            if (num >= 1000)
                return (dnum / 1000D).ToString("0.##k");
            return dnum.ToString("#,0");
        }

        public string GetDisponibility()
        {
            switch(Status)
            {
                case Data.Status.ProductStatus.AVAILABLE:
                    return "available";
                    break;
                case Data.Status.ProductStatus.UNAVAILABLE:
                    return "unavailable";
                    break;
                case Data.Status.ProductStatus.INCOMMANDE:
                    return "unavailable, in command...";
                    break;
                case Data.Status.ProductStatus.LIQUIDATION:
                    return "In liquidation!";
                    break;
                case Data.Status.ProductStatus.PROMOTION:
                    return "In promotion!";
                    break;
                default: return "";
            }
        }
    }

    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("The id cannot be empty!");

            RuleFor(e => e.Name)
                .NotEmpty()
                .WithMessage("The name cannot be empty!");

            RuleFor(e => e.Price)
                .NotEmpty().WithMessage("The price cannot be empty!")
                .GreaterThan(0).WithMessage("The price must be higher than $0.0");

            RuleFor(e => e.Discount)
                .NotEmpty().WithMessage("The discount cannot be empty!")
                .When(e => e.Discount >= 0 && e.Discount <= 100).WithMessage("The discount must be greater or equal and 0 and less or equal than 100");

            RuleFor(e => e.MaxContractTime)
                .NotEmpty().WithMessage("The id cannot be empty!")
                .When(e => e.MaxContractTime >= 0 && e.MaxContractTime <= 25).WithMessage("The discount must be greater or equal and 0 and less or equal than 25");

            RuleFor(e => e.DateNaissance)
                .NotEmpty().WithMessage("The date cannot be empty!")
                .When(e => e.DateNaissance <= DateTime.Now).WithMessage("The date must be before today!");

            RuleFor(e => e.Status)
                .NotEmpty()
                .WithMessage("The Status cannot be empty!");

            RuleFor(e => e.ProductCategory)
                .NotEmpty()
                .WithMessage("The type cannot be empty!");
        }
    }
}
