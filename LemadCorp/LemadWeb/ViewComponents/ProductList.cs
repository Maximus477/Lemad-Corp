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
            string product = null,
            string search = null,
            string spilot = "false",
            string sengineer = "false",
            string smechanic = "false",
            string sprincipal = "false",
            string spowerunit = "false",
            int? pageNumber = 1)
        {
            int pageSize = 5;
            if (product == "DRIVER") {
                ViewData["show"] = spilot;
                if (spilot == "false")
                    return View("driver", PaginatedList<Drivers>.CreateAsync(new List<Drivers>(), pageNumber ?? 1, pageSize));
                
                var item = await _context.pilots.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("driver", PaginatedList<Drivers>.CreateAsync(item, pageNumber ?? 1, pageSize));
            }
            
            else if (product == "TECHNICALCHIEF") {
                ViewData["show"] = sengineer;
                if (sengineer == "false")
                    return View("technicalchief", new List<TechnicalChiefs>());

                var item = await _context.engineers.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("technicalchief", item);
            }

            else if (product == "RACEENGINEER") {
                ViewData["show"] = smechanic;
                if (smechanic == "false")
                    return View("raceengineer", new List<RaceEngineers>());

                var item = await _context.mechanics.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("raceengineer", item);
            }

            else if (product == "PRINCIPAL") {
                ViewData["show"] = sprincipal;
                if (sprincipal == "false")
                    return View("principal", new List<Principals>());

                var item = await _context.principals.ToListAsync();
                if (!string.IsNullOrEmpty(search))
                    item = item.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToList();
                ViewBag.Verification = (item.Count() > 0) ? true : false;
                return View("principal", item);
            }

            else if (product == "POWERUNIT") {
                ViewData["show"] = spowerunit;
                if (spowerunit == "false")
                    return View("powerunit", new List<PowerUnits>());

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
