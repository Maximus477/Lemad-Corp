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
using LemadWeb.ViewModels.Account;
using LemadDb.Data;
using LemadDb.Domain.Entities;

namespace LemadWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET : Account/Login
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        // POST : Account/Login
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM model, string ReturnUrl = "/Home/Index")
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _signInManager.PasswordSignInAsync(
                model.Email, model.Password, false, false);

            if (result.IsLockedOut)
                return View("Lockout");

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Connexion échouée!");
                return View(model);
            }

            if (User.Identity.IsAuthenticated)
            {
                ApplicationUser user = User.Identity as ApplicationUser;
            }

            return new RedirectResult(url: ReturnUrl, permanent: true, preserveMethod: true);
        }

        // GET:  Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST : Account/Register
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Password != model.PasswordConfirmation)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Cellphone = model.PhoneNumber,
                UserName = model.Email,
                Email = model.Email,
                CivicAddresses = new List<AddressUser>(),
            };

            var addressCivique = new AdresseCivique
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                City = model.City,
                Province = model.Province,
                Country = model.Country,
                PostalCode = model.PostalCode,
            };

            var addressUser = new AddressUser()
            {
                AdresseCiviqueId = addressCivique.Id,
                ApplicationUserId = user.Id
            };

            user.CivicAddresses.Add(addressUser);

            //user.CivicAddresses.Add(AddressCivique);

            // Add adresseUser to addresseCivique

            _context.CivicAddresses.Add(addressCivique);
            var result = await _userManager.CreateAsync(user, model.Password);

            //var a = _context.AdresseCivique.FirstOrDefault(a => a.UserId == "dcf0ecff-a189-4d7e-8bd8-24e6bee818d7");

            //_context.AdresseCivique.Add(AddressCivique);
            //user.CivicAddresses.Add(AddressCivique);
            _context.SaveChanges();

            if (!result.Succeeded)
            {
                ModelState.AddModelError(String.Empty, "Password or Username invalid!");
                return View(model);
            }

            return RedirectToAction(nameof(Login));
        }

        // GET : Account/LogOut
        [Authorize]
        public async Task<IActionResult> Logout(string ReturnUrl = "/Home/Index")
        {
            try
            {
                await _signInManager.SignOutAsync();
            }
            catch (Exception)
            {
                ModelState.AddModelError(String.Empty, "The disconnect failed!");
                return RedirectToPage(ReturnUrl);
            }

            return RedirectToPage(ReturnUrl);
        }

        // GET : Account/Details
        [Authorize]
        public async Task<IActionResult> Details()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            // necessary pour le include
            var user2 = await _userManager.Users
            .Include(x => x.CivicAddresses)
            .SingleAsync(x => x.Id == user.Id);

            var addresses = new List<AdresseCivique>();

            foreach (var addresseUser in user2.CivicAddresses)
            {
                addresses.Add(_context.CivicAddresses.Find(addresseUser.AdresseCiviqueId));
            }

            var userAdresse = new AccountDetails()
            {
                FirstName = user2.FirstName,
                Lastname = user2.LastName,
                Email = user2.Email,
                PhoneNumber = user2.Cellphone,
                AdresseCiviques = addresses
            };

            return View(userAdresse);
        }

        // GET : Account/Commands
        [Authorize]
        public async Task<IActionResult> Commands()
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                List<Command> commands = new List<Command>();
                if (User.IsInRole("admin"))
                {
                    commands = _context.Commands.Include(c => c.ProductIDs).ToList();
                }
                else
                {
                    commands = _context.Commands.Include(c => c.ProductIDs).Where(c => c.ApplicationUserId == user.Id).ToList();
                }
                
                List<MyCommandsVM> mycommands = new List<MyCommandsVM>();
                foreach (var com in commands)
                {
                    List<ProductVM> products = new List<ProductVM>();
                    foreach (var product in com.ProductIDs)
                    {
                        var prod = _context.Products.FirstOrDefault(p => p.Id == product.ProductID);
                        var productVM = new ProductVM()
                        {
                            Name = prod.Name,
                            Price = prod.ActualPrice,
                            Quantity = com.ProductIDs.Where(pi => pi.ProductID == prod.Id).FirstOrDefault().Quantity
                        };
                        products.Add(productVM);
                    }

                    mycommands.Add(new MyCommandsVM()
                    {
                        Id = com.Id,
                        CreatedAt = com.CreatedAt,
                        FirstName = com.FirstName,
                        LastName = com.LastName,
                        Status = com.Status,
                        Total = com.TotalWithTaxes,
                        FullAddress = $"{com.Address}, {com.City}, {com.Province}, {com.Country}, {com.PostalCode}",
                        Products = products
                    });
                }

                return View(mycommands);
            }
            catch
            {
                return RedirectToAction("Commands", "Account");
                throw;
            }
        }


        [Authorize]
        public async Task<IActionResult> CommandCancelation(Guid? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var model = await _context.Commands.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
                var user = await _userManager.GetUserAsync(HttpContext.User);

                if (!User.IsInRole("admin"))
                {
                    if (model.ApplicationUser.Id != user.Id)
                    {
                        return RedirectToAction("Commands", "Account");
                    }
                }

                return View(model);
            }
            catch
            {
                return RedirectToAction("Commands", "Account");
            }
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CommandCancelation(Guid id)
        {
            try
            {
                var model = await _context.Commands.FindAsync(id);
                model.Status = LemadDb.Data.Enumerable.CommandStatus.CANCELED;
                _context.SaveChanges();
                return RedirectToAction("Commands", "Account");
            }
            catch
            {
                return RedirectToAction("Commands", "Account");
            }
        }

        // GET : Account/AddAddress
        [Authorize]
        public IActionResult AddAddress()
        {
            return View();
        }

        //POST : Account/Register
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddAddress(AdresseCivique model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user2 = await _userManager.GetUserAsync(HttpContext.User);

            // necessary pour le include
            var user = await _userManager.Users
            .Include(x => x.CivicAddresses)
            .SingleAsync(x => x.Id == user2.Id);

            var addressCivique = new AdresseCivique
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                City = model.City,
                Province = model.Province,
                Country = model.Country,
                PostalCode = model.PostalCode,
            };

            var addressUser = new AddressUser()
            {
                AdresseCiviqueId = addressCivique.Id,
                ApplicationUserId = user.Id
            };

            user.CivicAddresses.Add(addressUser);

            _context.CivicAddresses.Add(addressCivique);
            var result = await _userManager.UpdateAsync(user);

            _context.SaveChanges();

            return RedirectToAction("Details");
        }
    }
}
