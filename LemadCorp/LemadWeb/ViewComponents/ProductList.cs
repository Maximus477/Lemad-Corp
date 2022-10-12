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
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("pilot", item);
            } 
            else if (product == "ENGINEER") {
                var item = await _context.engineers.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("engineer", item);
            } 
            else if (product == "MECHANIC") {
                var item = await _context.mechanics.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("mechanic", item);
            } 
            else if (product == "PRINCIPAL") {
                var item = await _context.principals.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("principal", item);
            } 
            else if (product == "POWERUNIT") {
                var item = await _context.powerUnits.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.Name.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("powerunit", item);
            }
            else
                return View();
        }
    }
}
