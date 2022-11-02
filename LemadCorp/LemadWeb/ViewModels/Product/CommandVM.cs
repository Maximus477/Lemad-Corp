using LemadDb.Domain.User;
using LemadDb.Domain.Entities;
using System.Collections.Generic;

namespace LemadWeb.ViewModels.Product
{
    public class CommandVM
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public List<LemadDb.Domain.Entities.Product> Products { get; set; } = null;

        public CommandVM()
        {
            
        }

    }
}
