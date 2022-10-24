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
        public IActionResult List(string sortOrder, string searchString, string Pricefilter, string Statefilter, string CategoryFilter, string DiscountFilter)
        {
            if (sortOrder == null) { sortOrder = ""; }
            if (Pricefilter == null) { Pricefilter = ""; }
            if (Statefilter == null) { Statefilter = ""; }

            ListProductVM model = new ListProductVM(
                createListSearch(searchString), 
                Pricefilter, 
                Statefilter, 
                CategoryFilter, 
                DiscountFilter, 
                sortOrder, 
                String.IsNullOrEmpty(sortOrder) ? "name_desc" : "",
                sortOrder == "Price" ? "price_desc" : "Price",
                sortOrder == "Date" ? "date_desc" : "Date",
                sortOrder == "Discount" ? "discount_desc" : "Discount");

            verifierImage();
            return View(model);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                Product product = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Discount = model.Discount,
                    Status = model.Status,
                    ProductCategory = model.ProductCategory,
                    MaxContractTime = model.MaxContractTime,
                    DateNaissance = model.DateNaissance,
                    Description = model.Description,
                    Quote = model.Quote
                };

                if (Request.Form.Count > 0)
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

                if (product.Photo == null)
                {
                    return View(model);
                }

                _context.Add(product);
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            catch
            {
                return View(model);
            }
        }

        [Authorize(Roles = "Administrator")]
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
                return View(model);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Discount,MaxContractTime,DateNaissance,Description,Quote,ProductCategory,Status,Photo")] Product model)
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
                        Product product = await _context.Products.FindAsync(id);
                        product.Name = model.Name;
                        product.Price = model.Price;
                        product.Discount = model.Discount;
                        product.MaxContractTime = model.MaxContractTime;
                        product.DateNaissance = model.DateNaissance;
                        product.Description = model.Description;
                        product.Quote = model.Quote;
                        product.ProductCategory = model.ProductCategory;
                        product.Status = model.Status;
                        
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


        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
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
                return View(model);
            }
            catch
            {
                return RedirectToAction("List");
            }
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var model = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
                _context.Products.Remove(model);
                _context.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

        [AllowAnonymous]
        public IActionResult reload(int pageNumber, string sortOrder, string PriceFilter, string Statefilter, string CategoryFilter, string DiscountFilter, string search = "")
        {
            return ViewComponent("ProductList", new { search = createListSearch(search), pageNumber = pageNumber, sortOrder = sortOrder, PriceFilter = PriceFilter, Statefilter  = Statefilter, CategoryFilter = CategoryFilter, DiscountFilter  = DiscountFilter });
        }

        private List<string> createListSearch(string search)
        {
            List<string> listString = new List<string>();
            if (search == null) { listString.Add(""); }
            else
            {
                string name = "";
                int i = 0;
                foreach (char c in search)
                {
                    if (c == ',')
                    {
                        listString.Add(name);
                        name = "";
                        i++;
                    }
                    else if (i == search.Length - 1)
                    {
                        name += c;
                        listString.Add(name);
                    }
                    else
                    {
                        name += c;
                        i++;
                    }
                }
            }

            return listString;
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