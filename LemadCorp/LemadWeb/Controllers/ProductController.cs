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
using Microsoft.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization.Formatters.Binary;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        //#region Driver
        //[AllowAnonymous]
        //public IActionResult CreateDriver()
        //{
        //    return View();
        //}
        //
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> CreateDriver(DriverViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View();
        //        }
        //
        //        Drivers driver = new Drivers()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            Price = model.Price,
        //            Discount = model.Discount,
        //            Status = model.Status,
        //        };
        //
        //        _context.Add(driver);
        //        await _context.SaveChangesAsync();
        //
        //        return RedirectToAction("List");
        //    }
        //    catch
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
        //#endregion
        //
        //#region Principal
        //[AllowAnonymous]
        //public IActionResult CreatePrincipal()
        //{
        //    return View();
        //}
        //
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> CreatePrincipal(PrincipalViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View();
        //        }
        //
        //        Principals principal = new Principals()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            Price = model.Price,
        //            Discount = model.Discount,
        //            Status = model.Status,
        //        };
        //
        //        _context.Add(principal);
        //        await _context.SaveChangesAsync();
        //
        //        return RedirectToAction("List");
        //    }
        //    catch
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
        //#endregion
        //
        //#region TechnicalChief
        //[AllowAnonymous]
        //public IActionResult CreateTechnicalChief()
        //{
        //    return View();
        //}
        //
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> CreateTechnicalChief(TechnicalChiefViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View();
        //        }
        //
        //        TechnicalChiefs technicalChief = new TechnicalChiefs()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            Price = model.Price,
        //            Discount = model.Discount,
        //            Status = model.Status,
        //        };
        //        
        //        _context.Add(technicalChief);
        //        await _context.SaveChangesAsync();
        //
        //        return RedirectToAction("List");
        //    }
        //    catch
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
        //#endregion
        //
        //#region RaceEngineer
        //[AllowAnonymous]
        //public IActionResult CreateRaceEngineer()
        //{
        //    return View();
        //}
        //
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> CreateRaceEngineer(RaceEngineerViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View();
        //        }
        //
        //        RaceEngineers raceEngineer = new RaceEngineers()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            Price = model.Price,
        //            Discount = model.Discount,
        //            Status = model.Status,
        //        };
        //
        //        _context.Add(raceEngineer);
        //        await _context.SaveChangesAsync();
        //
        //        return RedirectToAction("List");
        //    }
        //    catch
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
        //#endregion
        //
        //#region PowerUnit
        //[AllowAnonymous]
        //public IActionResult CreatePowerUnit()
        //{
        //    return View();
        //}
        //
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> CreatePowerUnit(PowerUnitViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View();
        //        }
        //
        //        PowerUnits powerUnit = new PowerUnits()
        //        {
        //            Name = model.Name,
        //            Price = model.Price,
        //            Discount = model.Discount,
        //            Status = model.Status,
        //        };
        //
        //        _context.Add(powerUnit);
        //        await _context.SaveChangesAsync();
        //
        //        return RedirectToAction("List");
        //    }
        //    catch
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //}
        //#endregion

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
                        string sqlQuery = @$"UPDATE Products SET Products.Photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{item.Path}', SINGLE_BLOB) AS x) WHERE Products.Id = {item.Id}";
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

        //string sqlQuery = $"SELECT d.BulkColumn FROM OPENROWSET(BULK N'{item.Path}', SINGLE_BLOB) as d";
        //
        //    SqlDataReader reader = command.ExecuteReader();
        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream();
        //    while (reader.Read())
        //    {
        //        bf.Serialize(ms, reader[0]);
        //        item.Photo = ms.ToArray();
        //    }
        //        
        //    _context.SaveChanges();
        //    reader.Close();
        //    //byte[] photo = Convert.FromBase64String(reader["BulkColumn"].ToString());
    }
}
