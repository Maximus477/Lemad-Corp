using FluentValidation.Validators;
using LemadDb.Data;
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
            string product = null,
            string search = null)
        {
            if (product == "PILOT") {
                var item = await _context.pilots.ToListAsync();
                if (search != null)
                    return View(item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)));
                else 
                    return View("pilot", item);
            } else if (product == "ENGINEER") {
                var item = await _context.engineers.ToListAsync();
                if (search != null)
                    return View(item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)));
                else
                    return View("engineer", item);
            } else if (product == "MECHANIC") {
                var item = await _context.mechanics.ToListAsync();
                if (search != null)
                    return View(item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)));
                else
                    return View("mechanic", item);
            } else if (product == "PRINCIPAL") {
                var item = await _context.principals.ToListAsync();
                if (search != null)
                    return View(item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)));
                else
                    return View("principal", item);
            } else if (product == "POWERUNIT") {
                var item = await _context.powerUnits.ToListAsync();
                if (search != null)
                    return View(item.Where(c => c.Name.Contains(search)));
                else
                    return View("powerunit", item);
            }
            else
                return View();
        }
    }
}
