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
using LemadDb.Data;
using LemadDb.Domain.Entities;
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

            return View();
        }

        #region Product
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                Product product = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                    ProductCategory = model.ProductCategory
                };

                _context.Add(product);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var model = await _context.Products.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
                //ProductViewModel viewModel = new ProductViewModel()
                //{
                //    Name = model.Name,
                //    Price = model.Price,
                //    Discount = model.Discount,
                //    Status = model.Status,
                //    ProductCategory = model.ProductCategory
                //};
                return View(model);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Discount,ProductCategory,Status,Photo")] Product model)
        {
            try
            {
                if (id != model.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(model);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductExists(model.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("List");
                }
                return View(model);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var model = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var product = await _context.Products
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (product == null)
                {
                    return NotFound();
                }

                return View(product);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var product = await _context.Products.FindAsync(Id);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("List");
            }
        }
        #endregion

        [AllowAnonymous]
        public IActionResult reload(int pageNumber, string search = "")
        {
            return ViewComponent("ProductList", new { search = search, pageNumber = pageNumber });
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
