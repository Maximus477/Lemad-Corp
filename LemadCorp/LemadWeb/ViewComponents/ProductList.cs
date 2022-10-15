using FluentValidation.Validators;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemadWeb.ViewComponents
{
    public class ProductList : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public ProductList(ApplicationDbContext context) { _context = context; }

        public async Task<IViewComponentResult> InvokeAsync(
            string sortOrder = null,
            string search = null,
            int? pageNumber = 1
            )
        {
            int pageSize = 12;
            var item = _context.Products.ToList();

            // Sorting:
            // Name
            // Price
            // Discount
            // Date

            // Filters:
            // Intervales de prix
            // Status
            // +2

            switch (sortOrder)
            {
                case "date_desc":
                    item = item.OrderByDescending(p => p.DateNaissance).ToList();
                    break;
                case "Date":
                    item = item.OrderBy(p => p.DateNaissance).ToList();
                    break;
                case "discount_desc":
                    item = item.OrderByDescending(p => p.Discount).ToList();
                    break;
                case "Discount":
                    item = item.OrderBy(p => p.Discount).ToList();
                    break;
                case "name_desc":
                    item = item.OrderByDescending(p => p.Name).ToList();
                    break;
                case "Price":
                    item = item.OrderBy(p => p.Price).ToList();
                    break;
                case "price_desc":
                    item = item.OrderByDescending(p => p.Price).ToList();
                    break;
                default:
                    item = item.OrderBy(p => p.Name).ToList();
                    break;
            }

            if (!string.IsNullOrEmpty(search))
                item = item.Where(c => c.Name.ToLower().Contains(search.ToLower()) || c.ProductCategory.ToString().ToLower().Contains(search.ToLower())).ToList();

            ViewBag.Verification = (item.Count() > 0) ? true : false;
            return View(PaginatedList<Product>.CreateAsync(item, pageNumber ?? 1, pageSize, search, sortOrder));
        }
    }
}
