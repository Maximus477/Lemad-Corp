using LemadDb.Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Linq;
using System.Threading.Tasks;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization.Formatters.Binary;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using LemadWeb.ViewModels.Product;
using System.Net.WebSockets;


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

            verifierImage();
            return View();
        }

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

                if (Request.Form.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    if (file != null)
                    {
                        using (var dataStream = new MemoryStream())
                        {
                            await file.CopyToAsync(dataStream);
                            product.Photo = dataStream.ToArray();
                        }
                    }
                }

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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Discount,ProductCategory,Status,Path,Photo")] Product model)
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
                        if (Request.Form.Count > 0)
                        {
                            IFormFile file = Request.Form.Files.FirstOrDefault();
                            if (file != null)
                            {
                                using (var dataStream = new MemoryStream())
                                {
                                    await file.CopyToAsync(dataStream);
                                    model.Photo = dataStream.ToArray();
                                }
                            }
                        }
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
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                if (Id == null) {
                    return NotFound();
                }

                var model = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);

                if (model == null) {
                    return NotFound();
                }

                return View(model);
            }
            catch {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        public IActionResult reload(int pageNumber, string search = "")
        {
            return ViewComponent("ProductList", new { search = search, pageNumber = pageNumber });
        }

        private void verifierImage()
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=LemadDb;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                foreach (Product item in _context.Products.ToList())
                {
                    if (item.Path != null && item.Photo == null)
                    {
                        string sqlQuery = @$"UPDATE Products SET Products.Photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{new FileInfo(item.Path).FullName}', SINGLE_BLOB) AS x) WHERE Products.Id = {item.Id}";
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = sqlQuery;

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
            }
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}