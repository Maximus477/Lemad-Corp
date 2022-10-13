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
using LemadDb.Domain.Entities;

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

        #region Driver
        [AllowAnonymous]
        public IActionResult CreateDriver()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateDriver(DriverViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                Drivers driver = new Drivers()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                };

                _context.Add(driver);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region Principal
        [AllowAnonymous]
        public IActionResult CreatePrincipal()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreatePrincipal(PrincipalViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                Principals principal = new Principals()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                };

                _context.Add(principal);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region TechnicalChief
        [AllowAnonymous]
        public IActionResult CreateTechnicalChief()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateTechnicalChief(TechnicalChiefViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                TechnicalChiefs technicalChief = new TechnicalChiefs()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                };
                
                _context.Add(technicalChief);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region RaceEngineer
        [AllowAnonymous]
        public IActionResult CreateRaceEngineer()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateRaceEngineer(RaceEngineerViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                RaceEngineers raceEngineer = new RaceEngineers()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                };

                _context.Add(raceEngineer);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region PowerUnit
        [AllowAnonymous]
        public IActionResult CreatePowerUnit()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreatePowerUnit(PowerUnitViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                PowerUnits powerUnit = new PowerUnits()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                };

                _context.Add(powerUnit);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

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
