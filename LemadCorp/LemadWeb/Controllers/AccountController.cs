﻿using LemadDb.Domain.User;
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

namespace LemadWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

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
        [AllowAnonymous]
        public async Task<IActionResult> Details()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            return View(user);
        }

        // GET : Account/Commands
        [AllowAnonymous]
        public IActionResult Commands()
        {
            return View();
        }
    }
}
