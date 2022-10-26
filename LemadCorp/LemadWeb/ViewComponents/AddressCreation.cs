using LemadDb.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Threading.Tasks;

namespace LemadWeb.ViewComponents
{
    public class AddressCreation : Component
    {
        private readonly ApplicationDbContext _context;

        public AddressCreation(ApplicationDbContext context) { _context = context; }

        /*public async Task<IViewComponentResult> InvokeAsync()
        {

        }*/
    }
}
