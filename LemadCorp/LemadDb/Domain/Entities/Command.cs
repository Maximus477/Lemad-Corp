using LemadDb.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.Entities
{
    public class Command
    {
        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        //public AdresseCivique AdresseCivique { get; set; }
        public List<CommandProduct> ProductIDs { get; set; }

        // nav
        //public List<int> ProductIDs { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
