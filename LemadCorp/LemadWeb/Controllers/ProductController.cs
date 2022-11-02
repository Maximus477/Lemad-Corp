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
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using JsonConverter = LemadDb.Data.JsonConverter;
using Microsoft.CodeAnalysis;

namespace LemadWeb.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        static private List<Product> _products;

        public ProductController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IConfiguration configuration) { _context = context; _userManager = userManager; _configuration = configuration; }

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

            return View(model);
        }


        [AllowAnonymous]
        public IActionResult Cart(string ProductId)
        {
            
            CartVM model;
            if (ProductId != "\"\"" && ProductId != null)
                    model = new CartVM(JsonConverter.jsonToIntDictionary(ProductId));
            else
                model = new CartVM(new Dictionary<int, int>());

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Command(string ProductId, string total, string totalDiscount, string totalWithDiscount, string totalWithTaxes)
        {
            CommandVM model = new CommandVM();
            var products = JsonConverter.jsonToIntDictionary(ProductId);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;
            model.Phone = user.PhoneNumber;
            model.UserID = user.Id;
            model.Products = new List<Product>();
            model.Total = total;
            model.TotalDiscount = totalDiscount;
            model.TotalWithDiscount = totalWithDiscount;
            model.TotalWithTaxes = totalWithTaxes;
            if (user.CivicAddresses != null)
            {
                model.Address = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Address;
                model.City = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().City;
                model.Province = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Province;
                model.Country = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Country;
                model.PostalCode = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().PostalCode;

            }
            foreach (var product in products)
            {
                model.Products.Add(_context.Products.Where(c => c.Id == product.Key).SingleOrDefault());
            }
            _products = model.Products;
            return View(model);
        }



        [Authorize]
        [HttpPost]
        public IActionResult Command(CommandVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                //LemadDb.Domain.Entities.Command command = new LemadDb.Domain.Entities.Command()
                //{
                //    FirstName = model.FirstName,
                //    LastName = model.LastName,
                //    Email = model.Email,
                //    PhoneNumber = model.Phone,
                //    CreatedAt = DateTime.Now,
                //    ApplicationUser = await _userManager.GetUserAsync(HttpContext.User),
                //    Address = model.Address,
                //    City = model.City,
                //    Province = model.Province,
                //    Country = model.Country,
                //    PostalCode = model.PostalCode,
                //};

                return RedirectToAction("CommandConfirmation", "Product", new { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, Phone = model.Phone, Address = model.Address, City = model.City, Province = model.Province, Country = model.Country, PostalCode = model.PostalCode, Total = model.Total, TotalDiscount = model.TotalDiscount, TotalWithDiscount = model.TotalWithDiscount, TotalWithTaxes = model.TotalWithTaxes });
                //command.ProductIDs = new List<CommandProduct>();
                //foreach(var item in _products)
                //{
                //    CommandProduct commandProduct = new CommandProduct(item.Id);
                //    command.ProductIDs.Add(commandProduct);
                //}

                //_context.Add(command);
                //await _context.SaveChangesAsync();

                //return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(model);
            }
        }

        [Authorize]
        public IActionResult CommandConfirmation(string FirstName, string LastName, string Email, string Phone, string Address, string City, string Province, string Country, string PostalCode, string Total, string TotalDiscount, string TotalWithDiscount, string TotalWithTaxes)
        {
            CommandVM model = new CommandVM()
            {
                FirstName = FirstName, LastName = LastName, Email = Email, Phone = Phone, Address = Address, City = City, Province = Province, Country = Country, TotalWithTaxes=TotalWithTaxes, TotalWithDiscount=TotalWithDiscount, PostalCode=PostalCode, TotalDiscount=TotalDiscount, Total=Total
            };
            model.Products = _products;
            //string FirstName, string LastName, string Email, string Phone, string Address, string City, string , string totalDiscount, string totalWithDiscount, string totalWithTaxes
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CommandConfirmation(CommandVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                LemadDb.Domain.Entities.Command command = new LemadDb.Domain.Entities.Command()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.Phone,
                    CreatedAt = DateTime.Now,
                    ApplicationUser = await _userManager.GetUserAsync(HttpContext.User),
                    Address = model.Address,
                    City = model.City,
                    Province = model.Province,
                    Country = model.Country,
                    PostalCode = model.PostalCode,
                    Total = Decimal.Parse(model.Total),
                    TotalDiscount = Decimal.Parse(model.TotalDiscount),
                    TotalWithDiscount = Decimal.Parse(model.TotalWithDiscount),
                    TotalWithTaxes = Decimal.Parse(model.TotalWithTaxes),
                };
                command.ProductIDs = new List<CommandProduct>();
                foreach (var item in _products)
                {
                    CommandProduct commandProduct = new CommandProduct(item.Id);
                    command.ProductIDs.Add(commandProduct);
                }

                _context.Add(command);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(model);
            }
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
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


        [Authorize(Roles = "admin")]
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

        [AllowAnonymous]
        public IActionResult reloadCart(string products)
        {
            return ViewComponent("CartInfo", new { strProducts = products });
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

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}