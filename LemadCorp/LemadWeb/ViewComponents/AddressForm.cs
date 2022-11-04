using LemadDb.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LemadWeb.ViewComponents
{
    public class AddressForm : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public AddressForm(ApplicationDbContext context) { _context = context; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
