using FluentValidation.Validators;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            int? pageNumber = 1)
        {
            int pageSize = 12;
            var item = await _context.Products.ToListAsync();
            if (!string.IsNullOrEmpty(search))
                item = item.Where(c => c.Name.ToLower().Contains(search.ToLower())).ToList();

            ViewBag.Verification = (item.Count() > 0) ? true : false;
            return View(PaginatedList<Product>.CreateAsync(item, pageNumber ?? 1, pageSize, search));
        }
    }
}
