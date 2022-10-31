using FluentValidation.Validators;
using LemadDb.Data;
using LemadDb.Domain.Entities;
using LemadWeb.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewComponents
{
    public class CartInfo : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartInfo(ApplicationDbContext context) { _context = context; }

        public async Task<IViewComponentResult> InvokeAsync(
            Dictionary<Product, string> products = null,
            string strProducts = null)
        {
            Dictionary<Product, string> lstProduct = new Dictionary<Product, string>();
            if (products != null) {
                lstProduct = products;
            }
            else if (strProducts != null) {
                Dictionary<string, string> dictionary = createDictionnarySearch(strProducts);
                foreach (var item in dictionary) {
                    lstProduct.Add(_context.Products.Where(c => c.Id == int.Parse(item.Key)).SingleOrDefault(), item.Value);
                }
            }

            decimal total = 0;
            decimal totalDiscount = 0;
            decimal totalWithDiscount = 0;
            byte count = 0;
            if (lstProduct.Count > 0)
            {
                foreach (var item in lstProduct)
                {
                    count++;
                    total += (item.Key.Price * int.Parse(item.Value));
                    totalDiscount += ((decimal)((double)item.Key.Price * (item.Key.Discount / 100d)) * int.Parse(item.Value));
                    totalWithDiscount += (item.Key.Price * int.Parse(item.Value)) - ((decimal)((double)item.Key.Price * (item.Key.Discount / 100d)) * int.Parse(item.Value));
                }
            }

            decimal totalWithTaxes = totalWithDiscount + (totalWithDiscount * (5 / 100)) + (totalWithDiscount * (decimal)(9.975 / 100));

            return View(new CartInfoVM { CountProduct = count, Total = total, TotalDiscount = totalDiscount, TotalWithDiscount = totalWithDiscount, TotalWithTaxes = totalWithTaxes });
        }

        private Dictionary<string, string> createDictionnarySearch(string lists)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] products = lists.Split(',');
            for (int i = 0; i < products.Length; ++i)
            {

                products[i] = products[i].Substring(products[i].IndexOf("{") + 1);
                products[i] = products[i].Substring(0, products[i].IndexOf("}"));

                string[] product = products[i].Split(';');
                dictionary.Add(product[0], product[1]);
            }

            return dictionary;
        }
    }
}
