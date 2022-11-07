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
        static private Dictionary<int, int> _command;

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

        [AllowAnonymous]
        public async Task<IActionResult> Command(string ProductId, string total, string totalDiscount, string totalWithDiscount, string totalWithTaxes)
        {
            if (User.Identity.IsAuthenticated && !User.IsInRole("admin"))
            {
                var user2 = await _userManager.GetUserAsync(HttpContext.User);

                // necessary pour le include
                var user = await _userManager.Users
                .Include(x => x.CivicAddresses)
                .SingleAsync(x => x.Id == user2.Id);

                var addresses = new List<AdresseCivique>();

                foreach (var addresseUser in user2.CivicAddresses)
                {
                    addresses.Add(_context.CivicAddresses.Find(addresseUser.AdresseCiviqueId));
                }

                //String Text = a.Address + ", " + a.City + ", " + a.Province + ", " + a.Country + ", " + a.PostalCode

                ViewBag.Addresses = new SelectList(addresses, "Id", "Address");

                CommandVM model = new CommandVM();
                _command = JsonConverter.jsonToIntDictionary(ProductId);

                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.Email = user.Email;
                model.Phone = user.Cellphone;
                model.UserID = user.Id;
                model.Products = new List<Product>();
                model.Total = total;
                model.TotalDiscount = totalDiscount;
                model.TotalWithDiscount = totalWithDiscount;
                model.TotalWithTaxes = totalWithTaxes;
                model.AddNewAddress = true;

                if (user.CivicAddresses != null)
                {
                    model.Address = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Address;
                    model.City = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().City;
                    model.Province = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Province;
                    model.Country = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().Country;
                    model.PostalCode = _context.CivicAddresses.Where(c => c.Id == user.CivicAddresses.FirstOrDefault().AdresseCiviqueId).FirstOrDefault().PostalCode;
                }
                foreach (var product in _command)
                {
                    model.Products.Add(_context.Products.Where(c => c.Id == product.Key).SingleOrDefault());
                }

                _products = model.Products;

                return View(model);
            }
            else
            {
                CommandVM model = new CommandVM();
                _command = JsonConverter.jsonToIntDictionary(ProductId);
                foreach (var product in _command)
                {
                    model.Products.Add(_context.Products.Where(c => c.Id == product.Key).SingleOrDefault());
                }

                _products = model.Products;
                return View(model);
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public IActionResult Command(CommandVM model, bool newAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (!model.AddNewAddress)
                {
                    AdresseCivique ad = _context.CivicAddresses.Find(model.SelectedAddress);
                    model.Address = ad.Address;
                    model.Province = ad.Province;
                    model.Country = ad.Country;
                    model.City = ad.City;
                    model.PostalCode = ad.PostalCode;
                    model.Country = ad.Country;
                }

                return RedirectToAction("CommandConfirmation", "Product", new
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    City = model.City,
                    Province = model.Province,
                    Country = model.Country,
                    PostalCode = model.PostalCode,
                    Total = model.Total,
                    TotalDiscount = model.TotalDiscount,
                    TotalWithDiscount = model.TotalWithDiscount,
                    TotalWithTaxes = model.TotalWithTaxes
                });
            }
            catch
            {
                return View(model);
            }
        }

        [AllowAnonymous]
        public IActionResult CommandConfirmation(string FirstName, string LastName, string Email, string Phone, string Address, string City, string Province, string Country, string PostalCode, string Total, string TotalDiscount, string TotalWithDiscount, string TotalWithTaxes)
        {
            CommandVM model = new CommandVM()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Phone = Phone,
                Address = Address,
                City = City,
                Province = Province,
                Country = Country,
                TotalWithTaxes = "",
                TotalWithDiscount = "",
                PostalCode = PostalCode,
                TotalDiscount = "",
                Total = "",
                CommandDictionary = _command
            };
            model.Products = _products;

            decimal total = 0, totalDiscount = 0, totalWithDiscount = 0, totalWithTaxes = 0;

            foreach (var p in model.Products)
            {
                int quantity = _command[p.Id];
                total += p.Price * quantity;
                var discount = ((decimal)p.Discount) / 100;
                totalDiscount += discount * p.Price * quantity;
            }
            totalWithDiscount = total - totalDiscount;
            totalWithTaxes = totalWithDiscount + (totalWithDiscount * (5 / 100)) + (totalWithDiscount * (decimal)(9.975 / 100));

            model.Total = FormatNumber(total);
            model.TotalDiscount = FormatNumber(totalDiscount);
            model.TotalWithDiscount = FormatNumber(totalWithDiscount);
            model.TotalWithTaxes = FormatNumber(totalWithTaxes);

            //string FirstName, string LastName, string Email, string Phone, string Address, string City, string , string totalDiscount, string totalWithDiscount, string totalWithTaxes
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CommandConfirmation(CommandVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                LemadDb.Domain.Entities.Command command;

                decimal total = 0, totalDiscount = 0, totalWithDiscount = 0, totalWithTaxes = 0;

                foreach (var p in _products)
                {
                    int quantity = _command[p.Id];
                    total += p.Price * quantity;
                    var discount = ((decimal)p.Discount) / 100;
                    totalDiscount += discount * p.Price * quantity;
                }
                totalWithDiscount = total - totalDiscount;
                totalWithTaxes = totalWithDiscount + (totalWithDiscount * (5 / 100)) + (totalWithDiscount * (decimal)(9.975 / 100));

                model.Total = total.ToString();
                model.TotalDiscount = totalDiscount.ToString();
                model.TotalWithDiscount = totalWithDiscount.ToString();
                model.TotalWithTaxes = totalWithTaxes.ToString();

                if (User.Identity.IsAuthenticated)
                {
                    command = new LemadDb.Domain.Entities.Command()
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
                        Status = LemadDb.Data.Enumerable.CommandStatus.CONFIRMED
                    };
                }
                else
                {
                    command = new LemadDb.Domain.Entities.Command()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        PhoneNumber = model.Phone,
                        CreatedAt = DateTime.Now,
                        ApplicationUser = _context.Users.Where(x => x.Email == "guest@user.com").FirstOrDefault(),
                        Address = model.Address,
                        City = model.City,
                        Province = model.Province,
                        Country = model.Country,
                        PostalCode = model.PostalCode,
                        Total = Decimal.Parse(model.Total),
                        TotalDiscount = Decimal.Parse(model.TotalDiscount),
                        TotalWithDiscount = Decimal.Parse(model.TotalWithDiscount),
                        TotalWithTaxes = Decimal.Parse(model.TotalWithTaxes),
                        Status = LemadDb.Data.Enumerable.CommandStatus.CONFIRMED
                    };
                }
                command.ProductIDs = new List<CommandProduct>();
                foreach (var item in _command)
                {
                    CommandProduct commandProduct = new CommandProduct(item.Key, item.Value);
                    command.ProductIDs.Add(commandProduct);
                }

                _context.Add(command);
                await _context.SaveChangesAsync();

                return RedirectToAction("Commands", "Account");
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
            return ViewComponent("ProductList", new { search = createListSearch(search), pageNumber = pageNumber, sortOrder = sortOrder, PriceFilter = PriceFilter, Statefilter = Statefilter, CategoryFilter = CategoryFilter, DiscountFilter = DiscountFilter });
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

        internal static long MaxThreeSignificantDigits(long x)
        {
            int i = (int)Math.Log10(x);
            i = Math.Max(0, i - 2);
            i = (int)Math.Pow(10, i);
            return x / i * i;
        }
        private string FormatNumber(decimal num)
        {
            num = MaxThreeSignificantDigits((long)num);
            Double dnum = Decimal.ToDouble(num);

            if (num >= 100000000)
                return (dnum / 1000000D).ToString("0.#M") + "$";
            if (num >= 1000000)
                return (dnum / 1000000D).ToString("0.##M") + "$";
            if (num >= 100000)
                return (dnum / 1000D).ToString("0k") + "$";
            if (num >= 100000)
                return (dnum / 1000D).ToString("0.#k") + "$";
            if (num >= 1000)
                return (dnum / 1000D).ToString("0.##k") + "$";
            return dnum.ToString("#,0") + "$";
        }
    }
}