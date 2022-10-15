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
            string search = null,
            int? pageNumber = 1,
            string sortOrder = null)
        {
            var products = from p in _context.Products
                          select p;

            // Sorting:
            // Name
            // Price
            // +2

            // Filters:
            // Intervales de prix
            // Status
            // +2

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(p => p.Name);
                    break;
                case "Price":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                default:
                    products = products.OrderBy(p => p.Name);
                    break;
            }

            int pageSize = 12;
            var item = products.ToList();
            if (!string.IsNullOrEmpty(search))
                item = item.Where(c => c.Name.ToLower().Contains(search.ToLower()) || c.ProductCategory.ToString().ToLower().Contains(search.ToLower())).ToList();

            ViewBag.Verification = (item.Count() > 0) ? true : false;
            return View(PaginatedList<Product>.CreateAsync(item, pageNumber ?? 1, pageSize, search));
        }
    }
}
