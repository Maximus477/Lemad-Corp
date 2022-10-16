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
            string Pricefilter = null,
            string Statefilter = null,
            int? pageNumber = 1)
        {
            int pageSize = 12;
            var item = _context.Products.ToList();

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

            if (!string.IsNullOrEmpty(Pricefilter))
            {
                switch (Pricefilter)
                {
                    case "tier1":
                        item = item.Where(c => c.Price <= 650000).ToList();
                        break;
                    case "tier2":
                        item = item.Where(c => c.Price > 650000 && c.Price <= 850000).ToList();
                        break;
                    case "tier3":
                        item = item.Where(c => c.Price > 850000 && c.Price <= 1000000).ToList();
                        break;
                    case "tier4":
                        item = item.Where(c => c.Price > 1000000 && c.Price <= 2000000).ToList();
                        break;
                    case "tier5":
                        item = item.Where(c => c.Price > 2000000 && c.Price <= 10000000).ToList();
                        break;
                    case "tier6":
                        item = item.Where(c => c.Price > 10000000 && c.Price <= 25000000).ToList();
                        break;
                    case "tier7":
                        item = item.Where(c => c.Price > 25000000).ToList();
                        break;
                }
            }
            if (!string.IsNullOrEmpty(Statefilter))
            {
                switch (Statefilter)
                {
                    case "AVAILABLE":
                        item = item.Where(c => c.Status == Status.ProductStatus.AVAILABLE).ToList();
                        break;
                    case "INCOMMANDE":
                        item = item.Where(c => c.Status == Status.ProductStatus.INCOMMANDE).ToList();
                        break;
                    case "UNAVAILABLE":
                        item = item.Where(c => c.Status == Status.ProductStatus.UNAVAILABLE).ToList();
                        break;
                    case "LIQUIDATION":
                        item = item.Where(c => c.Status == Status.ProductStatus.LIQUIDATION).ToList();
                        break;
                    case "PROMOTION":
                        item = item.Where(c => c.Status == Status.ProductStatus.PROMOTION).ToList();
                        break;
                }
            }

            ViewBag.Verification = (item.Count() > 0) ? true : false;
            return View(PaginatedList<Product>.CreateAsync(item, pageNumber ?? 1, pageSize, search, sortOrder, Pricefilter, Statefilter));
        }
    }
}
