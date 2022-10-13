using LemadDb.Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using LemadWeb.ViewModels.Product;
using LemadDb.Data;
using LemadWeb.ViewModels.Product;

namespace LemadWeb.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context) { _context = context; }

        [AllowAnonymous]
        public IActionResult List(string searchString)
        {
            if (searchString == null)
                searchString = "";

            ViewData["CurrentFilter"] = searchString;
            ViewData["PilotCount"] = 1;
            ViewData["EngineerCount"] = 1;
            ViewData["MechanicCount"] = 1;
            ViewData["PrincipalCount"] = 1;
            ViewData["PowerUnitCount"] = 1;

            return View();
        }

        [AllowAnonymous]
        public IActionResult reloadPilot(string show, int pageNumber, string nsearch = "")
        {
            return ViewComponent("ProductList", new { product = "DRIVER", search = nsearch, spilot = show, pageNumber = pageNumber });
        }

        [AllowAnonymous]
        public IActionResult reloadEngineer(string show, string nsearch = "")
        {
            return ViewComponent("ProductList", new { product = "TECHNICALCHIEF", search = nsearch, sengineer = show });
        }

        [AllowAnonymous]
        public IActionResult reloadMechanic(string show, string nsearch = "")
        {
            return ViewComponent("ProductList", new { product = "RACEENGINEER", search = nsearch, smechanic = show });
        }

        [AllowAnonymous]
        public IActionResult reloadPrincipal(string show, string nsearch = "")
        {
            return ViewComponent("ProductList", new { product = "PRINCIPAL", search = nsearch, sprincipal = show });
        }

        [AllowAnonymous]
        public IActionResult reloadPowerUnit(string show, string nsearch = "")
        {
            return ViewComponent("ProductList", new { product = "POWERUNIT", search = nsearch, spowerunit = show });
        }
    }
}
