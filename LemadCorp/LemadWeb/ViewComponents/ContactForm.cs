using FluentValidation.Validators;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewComponents
{
    public class ContactForm : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public ContactForm(ApplicationDbContext context) { _context = context; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
