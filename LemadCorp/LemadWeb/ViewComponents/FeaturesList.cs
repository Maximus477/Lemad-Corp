using FluentValidation.Validators;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewComponents
{
    public class FeaturesList : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public FeaturesList(ApplicationDbContext context) { _context = context; }

        public async Task<IViewComponentResult> InvokeAsync(string type)
        {
            List<Product> products = new List<Product>();
            List<Product> model = new List<Product>();
            Random rnd = new Random();

            switch (type) {
                case "DRIVER":
                    products = CalculateDriver();
                    break;

                case "ENGINEER":
                    products = CalculateEngineer();
                    break;

                case "TECHNICAL":
                    products = CalculateTechnical();
                    break;

                case "PRINCIPAL":
                    products = CalculatePrincipal();
                    break;

                case "POWERUNIT":
                    products = CalculatePowerUnit();
                    break;
            }

            for (int i = 0; i < 3; ++i)
            {
                int nombre = rnd.Next(0, products.Count);
                if (model.Contains(products[nombre]))
                    i--;
                else
                    model.Add(products[nombre]);
            }

            return View(model);
        }

        private List<Product> CalculateDriver()
        {
            List<Product> products = new List<Product>();

            products = _context.Products.Where(c => c.ProductCategory == ProductCategory.DRIVER)
                .Where(c => c.Status == ProductStatus.PROMOTION)
                .ToList();

            products.AddRange(_context.Products.Where(c => c.ProductCategory == ProductCategory.DRIVER)
                                .Where(c => c.Price >= 15000000).ToList());

            return products;
        }

        private List<Product> CalculateEngineer()
        {
            List<Product> products = new List<Product>();

            products = _context.Products.Where(c => c.ProductCategory == ProductCategory.RACEENGINEER)
                .Where(c => c.Status == ProductStatus.PROMOTION)
                .ToList();

            products.AddRange(_context.Products.Where(c => c.ProductCategory == ProductCategory.RACEENGINEER)
                                .Where(c => c.Price >= 1500000).ToList());

            return products;
        }

        private List<Product> CalculateTechnical()
        {
            List<Product> products = new List<Product>();

            products = _context.Products.Where(c => c.ProductCategory == ProductCategory.TECHNICALCHIEF)
                .Where(c => c.Status == ProductStatus.PROMOTION)
                .ToList();

            products.AddRange(_context.Products.Where(c => c.ProductCategory == ProductCategory.TECHNICALCHIEF)
                                .Where(c => c.Price >= 1000000).ToList());

            return products;
        }

        private List<Product> CalculatePrincipal()
        {
            List<Product> products = new List<Product>();

            products = _context.Products.Where(c => c.ProductCategory == ProductCategory.PRINCIPAL)
                .Where(c => c.Status == ProductStatus.PROMOTION)
                .ToList();

            products.AddRange(_context.Products.Where(c => c.ProductCategory == ProductCategory.PRINCIPAL)
                                .Where(c => c.Price >= 2000000).ToList());

            return products;
        }

        private List<Product> CalculatePowerUnit()
        {
            List<Product> products = new List<Product>();

            products = _context.Products.Where(c => c.ProductCategory == ProductCategory.POWERUNIT)
                .Where(c => c.Status == ProductStatus.PROMOTION)
                .ToList();

            products.AddRange(_context.Products.Where(c => c.ProductCategory == ProductCategory.POWERUNIT)
                                .Where(c => c.Price >= 35000000).ToList());

            return products;
        }
    }
}
